﻿using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class vHandler
{
    public Transform defaultHandler;
    public List<Transform> customHandlers;
    public vHandler()
    {
        customHandlers = new List<Transform>();
    }
}