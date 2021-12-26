/*
 *   Copyright (c) 2020 Araa
 *   All rights reserved.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform PlayerLoc;
    private Vector3 CamOffSet;
    // Start is called before the first frame update
    void Start()
    {
        CamOffSet.x = transform.position.x;
        CamOffSet.y = transform.position.y;
        CamOffSet.z = transform.position.z;
    }
    void Update() 
    {
    
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = PlayerLoc.position + CamOffSet;
    }
}
