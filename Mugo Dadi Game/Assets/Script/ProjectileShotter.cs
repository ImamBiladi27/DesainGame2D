/*
 *   Copyright (c) 2020 Araa
 *   All rights reserved.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShotter : MonoBehaviour
{
    public GameObject Fire;
    private int sendDMG;
    //public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {
        //Player playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSendDMG(int receivedDMG)
    {
        sendDMG = receivedDMG;
    }

    public void Shoot()
    {

        GameObject FireClone = Instantiate(Fire, transform.position, transform.rotation);
        ForceProjectile forceProjectile = FireClone.GetComponent<ForceProjectile>();
        forceProjectile.setDmg(sendDMG);

        Destroy(FireClone, 3f);
    }
}
