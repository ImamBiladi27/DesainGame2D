/*
 *   Copyright (c) 2020 Araa
 *   All rights reserved.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceProjectile : MonoBehaviour
{
    public Rigidbody Rigid;
    private int damage;
    public Vector3 Luncur;
    private void OnCollisionEnter(Collision other) 
    {
        GameObject projectileNabrak = other.gameObject;
        EnemyControler ec = projectileNabrak.GetComponent<EnemyControler>();

        if (other.collider.tag == "Enemy")
        {
            ec.damageTaken(damage);
            //Debug.Log(ec.currentHealth);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Rigid.AddRelativeForce(Luncur);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDmg(int dmg)
    {
        damage = dmg;
    }
}
