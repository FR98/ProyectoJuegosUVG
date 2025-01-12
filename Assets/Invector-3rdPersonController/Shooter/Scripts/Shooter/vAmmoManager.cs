﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Invector.ItemManager;
using System;
using Invector;

[vClassHeader("Ammo Manager", iconName = "ammoIcon")]
public class vAmmoManager : vMonoBehaviour
{
    public vAmmoListData ammoListData;
    [HideInInspector]
    public vItemManager itemManager;

    [HideInInspector]
    public List<vAmmo> ammos = new List<vAmmo>();
    public delegate void OnUpdateTotalAmmo();
    public OnUpdateTotalAmmo updateTotalAmmo = delegate { };

    void Start()
    {
        itemManager = GetComponent<vItemManager>();
        if (itemManager)
        {
            itemManager.onAddItem.AddListener(AddAmmo);
            itemManager.onDropItem.AddListener(DropAmmo);
            itemManager.onLeaveItem.AddListener(LeaveAmmo);
            itemManager.onChangeItemAmount.AddListener(ChangeItemAmount);
        }

        if (ammoListData)
        {
            ammos.Clear();
            for (int i = 0; i < ammoListData.ammos.Count; i++)
            {
                var ammo = new vAmmo(ammoListData.ammos[i]);
                ammo.onDestroyAmmoItem = new vAmmo.OnDestroyItem(OnDestroyAmmoItem);
                ammos.Add(ammo);
            }
        }
    }

    public vAmmo GetAmmo(int id)
    {
        return ammos.Find(a => a.ammoID == id);
    }

    public void AddAmmo(string ammoName, int id, int amount)
    {
        var ammo = ammos.Find(a => a.ammoID == id);
        if (ammo == null)
        {
            ammo = new vAmmo(ammoName, id, amount);
            ammos.Add(ammo);
            ammo.onDestroyAmmoItem = new vAmmo.OnDestroyItem(OnDestroyAmmoItem);
        }
        else if (ammo != null)
        {
            ammo.AddAmmo(amount);
        }
        UpdateTotalAmmo();
    }

    public void AddAmmo(int id, int amount)
    {
        var ammo = ammos.Find(a => a.ammoID == id);
        if (ammo == null)
        {
            ammo = new vAmmo("", id, amount);
            ammos.Add(ammo);
            ammo.onDestroyAmmoItem = new vAmmo.OnDestroyItem(OnDestroyAmmoItem);
        }
        else if (ammo != null)
        {
            ammo.AddAmmo(amount);
        }
        UpdateTotalAmmo();
    }

    public void AddAmmo(vItem item)
    {
        if (item.type == vItemType.Ammo)
        {
            var ammo = ammos.Find(a => a.ammoID == item.id);
            if (ammo == null)
            {
                ammo = new vAmmo(item.name, item.id, item.amount);
                ammos.Add(ammo);
                ammo.onDestroyAmmoItem = new vAmmo.OnDestroyItem(OnDestroyAmmoItem);
            }
            ammo.ammoItems.Add(item);
        }
        UpdateTotalAmmo();
    }

    protected void ChangeItemAmount(vItem item)
    {
        if (item.type == vItemType.Ammo)
        {
            var ammo = ammos.Find(a => a.ammoID == item.id);
            if (ammo == null)
            {
                ammo = new vAmmo(item.name, item.id, item.amount);
                ammos.Add(ammo);
                ammo.onDestroyAmmoItem = new vAmmo.OnDestroyItem(OnDestroyAmmoItem);
            }
        }
        UpdateTotalAmmo();
    }

    public void LeaveAmmo(vItem item, int amount)
    {
        if (item.type == vItemType.Ammo)
        {
            var ammo = ammos.Find(a => a.ammoID == item.id);
            if (ammo != null)
            {
                if ((item.amount - amount) <= 0 && ammo.ammoItems.Contains(item))
                    ammo.ammoItems.Remove(item);
            }
        }
        UpdateTotalAmmo();
    }

    public void DropAmmo(vItem item, int amount)
    {
        if (item.type == vItemType.Ammo)
        {
            var ammo = ammos.Find(a => a.ammoID == item.id);
            if (ammo != null)
            {
                if ((item.amount - amount) <= 0 && ammo.ammoItems.Contains(item))
                    ammo.ammoItems.Remove(item);
            }
        }
        UpdateTotalAmmo();
    }

    public void UpdateTotalAmmo()
    {
        updateTotalAmmo.Invoke();
    }

    void OnDestroyAmmoItem(vItem item)
    {
        if (itemManager) itemManager.LeaveItem(item, item.amount);
    }
}

namespace Invector
{
    [System.Serializable]
    public class vAmmo
    {
        public string ammoName;
        [Tooltip("Ammo ID - if is using ItemManager, make sure your AmmoManager and ItemListData use the same ID")]
        public int ammoID;
        [Tooltip("Don't need to setup if you're using a Inventory System")]
        [SerializeField]
        private int _count;

        public List<vItem> ammoItems;
        public delegate void OnDestroyItem(vItem item);
        public OnDestroyItem onDestroyAmmoItem = delegate { };
        public vAmmo()
        {
            ammoItems = new List<vItem>();
        }
        public vAmmo(string ammoName, int ammoID, int amount = 0)
        {
            this.ammoName = ammoName;
            this.ammoID = ammoID;
            this._count = amount;
            ammoItems = new List<vItem>();
        }
        public vAmmo(int ammoID, int amount = 0)
        {
            this.ammoID = ammoID;
            this._count = amount;
            ammoItems = new List<vItem>();
        }

        public vAmmo(vAmmo ammo)
        {
            this.ammoName = ammo.ammoName;
            this.ammoID = ammo.ammoID;
            this.ammoItems = ammo.ammoItems;
            this._count = ammo.count;
            ammoItems = new List<vItem>();
        }

        public int count
        {
            get
            {
                var value = 0;
                if (ammoItems != null && ammoItems.Count > 0)
                {
                    for (int i = 0; i < ammoItems.Count; i++)
                        if (ammoItems[i])
                            value += ammoItems[i].amount;
                }
                return _count + value;
            }
        }

        public void Use()
        {
            var ammoItem = ammoItems.Find(a => a.amount > 0);
            if (ammoItem)
            {
                ammoItem.amount--;
                if (ammoItem.amount == 0)
                {
                    ammoItems.Remove(ammoItem);
                    onDestroyAmmoItem(ammoItem);
                }
                return;
            }
            else if (_count > 0) _count--;
        }

        public void Use(int amout)
        {
            for (int i = 0; i < amout; i++) Use();
        }

        public void AddAmmo(int amount)
        {
            var ammoItem = ammoItems.Find(a => a.maxStack - a.amount >= amount);
            if (ammoItem)
            {
                ammoItem.amount += amount;
            }
        }
    }
}

