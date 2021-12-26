using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (Player.tag == "Player")
        {
            Hati2.health -= 1;
        }
    }
}
