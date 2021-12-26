using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hati2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject heart1, heart2, gameOver;
    public static int health;
    void Start()
    {
        health = 2;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        //gameOver.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 2)
            health = 2;
        switch (health)
        {
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);

                Time.timeScale = 0;
              
                break;
        }
    }
}
