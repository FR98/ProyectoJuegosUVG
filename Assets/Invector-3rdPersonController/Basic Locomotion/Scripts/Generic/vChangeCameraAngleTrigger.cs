﻿using UnityEngine;
using System.Collections;

public class vChangeCameraAngleTrigger : MonoBehaviour {
    public bool applyY, applyX;
    public Vector2 angle;
    public vThirdPersonCamera tpCamera;
    void Start()
    {
        tpCamera = FindObjectOfType<vThirdPersonCamera>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")&& tpCamera)
        {
            if(applyX)
                tpCamera.lerpState.fixedAngle.x = angle.x;
            if (applyY)
                tpCamera.lerpState.fixedAngle.y = angle.y;
        }
    }
}
