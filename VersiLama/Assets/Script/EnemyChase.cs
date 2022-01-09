/*
 *   Copyright (c) 2020 Araa
 *   All rights reserved.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyChase : MonoBehaviour
{
    public NavMeshAgent Enemy;
    GameObject player;
    public float rotateSpeed;
    public float forwardSpeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(player.transform.position);
        
    }
}
