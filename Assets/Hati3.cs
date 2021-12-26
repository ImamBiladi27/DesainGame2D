using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hati3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject heart3, heart4, gameOver,AI;
    public static int health;
    void Start()
    {
        health = 2;
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        //gameOver.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        AI.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 2)
            health = 2;
        switch (health)
        {
            case 2:
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                break;
            case 1:
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                break;
            case 0:
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                //gameOver.gameObject.SetActive(true);
                AI.gameObject.SetActive(false);
                //Time.timeScale = 0;

                break;
        }
    }
}
