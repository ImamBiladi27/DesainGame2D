/*
 *   Copyright (c) 2020 Araa
 *   All rights reserved.
 */
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameHandler;
    public Transform attackDirection;

    GameManager gameManager;
    public Joystick analog;
    public Joystick attackAnalog;

    public float forwardSpeed;
    public float rotateSpeed;

    public GameObject CastFire;
    ProjectileShotter FireBall;

    public float inputAttackTimer;
    private float attackTimer;
    private bool attackAvailable;
    public int basicAttackDamage;

    public int health;
    private int currentHealth;

    public float mana;
    private float currentMana;
    public float manaConsume;

    public float Mana_Regen;

    public ManaBarScript manaBar;
    public HealthBarScript healthBar;
    private bool analogAttackTriggered = false;
    private bool overheat = false;

    //public GameObject damagedAnim;
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = gameHandler.GetComponent<GameManager>();
        gameHandler = GameObject.Find("Main Camera");

        currentHealth = health;
        healthBar.SetMaxHealth(health);

        currentMana = mana;
        manaBar.SetMaxMana(mana);
        FireBall = CastFire.GetComponent<ProjectileShotter>();
        FireBall.setSendDMG(basicAttackDamage);

        attackTimer = inputAttackTimer;
        attackAvailable = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = health;
        healthBar.SetHealth(currentHealth);

        currentMana = mana;
        manaBar.SetMana(currentMana);

        analogMovement();
        analogAttack();

        if(health <= 0)
        {
            gameManager.playerDead();
        }

        manaRegen();
        attackCD();
        overHeat();
    }

    void analogMovement()
    {
        float angle = Mathf.Atan2(analog.Horizontal, analog.Vertical) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, angle, transform.eulerAngles.z));
        
        if(analog.Horizontal != 0 || analog.Vertical != 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);
            transform.Translate(0, 0, forwardSpeed * Time.deltaTime);
            if(!analogAttackTriggered)
                attackDirection.rotation = Quaternion.Slerp(attackDirection.rotation, rotation, rotateSpeed * Time.deltaTime);
        }
    }

    void analogAttack()
    {
        float angle = Mathf.Atan2(attackAnalog.Horizontal, attackAnalog.Vertical) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(new Vector3(attackDirection.eulerAngles.x, angle, attackDirection.eulerAngles.z));

        if (attackAnalog.Horizontal != 0 || attackAnalog.Vertical != 0)
        {
            analogAttackTriggered = true;
            attackDirection.rotation = Quaternion.Slerp(attackDirection.rotation, rotation, rotateSpeed *2* Time.deltaTime);
            Shoot();
            //transform.Translate(0, 0, forwardSpeed * Time.deltaTime);
        }
        else
            analogAttackTriggered = false;
    }

  

    public void Shoot()
    {
        if(mana>=15 && attackAvailable && !overheat)
        {
            FireBall.Shoot();
            mana -= manaConsume;
            attackAvailable = false;
           // Debug.Log(mana);

        }
        //Debug.Log("MANA MANANYA");
    }

    void attackCD()
    {
        attackTimer -= Time.deltaTime;
        if(attackTimer <=0)
        {
            attackAvailable = true;
            attackTimer = inputAttackTimer;
            //Debug.Log("Attak gan");
        }
    }

    void overHeat()
    {
        if (mana <= 12)
            overheat = true;
        if (mana >= 99)
            overheat = false;
    }

    void manaRegen()
    {
        if(mana <= 100)
        {
            mana += Mana_Regen*Time.deltaTime;
        }
    }

    public void usePotion(int HP_Restore)
    {
        Debug.Log("Potion nya man");
        health = health + HP_Restore;
        if (health > 100)
            health = 100;
    }
}