/*
 *   Copyright (c) 2020 Araa
 *   All rights reserved.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    //public int damageTaken;
    public int HP=100;

    public GameObject potionSpawn;

    private int currentPotionLimit;

    public HealthBarScript healthBar;
    public int currentHealth;

    SpawnEnemy spawnEnemy;
    GameObject gameHandler;

    GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        
        gameHandler = GameObject.Find("Main Camera");
        gameManager = gameHandler.GetComponent<GameManager>();
        currentHealth = HP;
        healthBar.SetMaxHealth(HP);
        currentPotionLimit = gameManager.limitPotionDrop;
        Debug.Log(currentPotionLimit);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(currentHealth);
        if(HP<=0)
        {
            Enemydead();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Projectile")
        {

            //Debug.Log(HP);
        }
    }

    public void damageTaken(int dmg)
    {
        HP -= dmg;
        currentHealth = HP;
    }

    void drop_potion()
    {
        GameObject PotionClone = Instantiate(potionSpawn, transform.position, transform.rotation);
    }

    void Enemydead()
    {

        
        gameManager.jumlahEnemy--;

        //Debug.Log("Jumlah Enemy " + gameManager.jumlahEnemy);
        gameManager.addScore();
        if (gameManager.getCurrentKill() == currentPotionLimit)
        {
            //gameManager.limitPotionDrop += currentPotionLimit;
            Debug.Log(currentPotionLimit);
            drop_potion();
            gameManager.resetCurrentKill();
        }
        Destroy(gameObject);
    }

}
