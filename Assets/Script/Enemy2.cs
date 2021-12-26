using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
  void OnTriggerEnter2D(Collider2D col)
    {
       
        if(col.tag == "Player")
        {
            //var healtComponent = col.GetComponent<Health>();
            Hati2.health -= 1;
        }
        else if(col.tag == "char2")
        {
            Hati3.health -= 1;
        }
    }
}
