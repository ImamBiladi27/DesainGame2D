﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    public GameObject player;
    public float jarak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(player.transform.localPosition.x + (player.transform.localScale.x * jarak), 0, -20f);
        transform.localPosition = Vector3.Slerp(transform.localPosition, pos, 1.2f);
    }
}
