using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private int HPget = 30;
    GameObject playerObject;

    private void OnCollisionEnter(Collision other)
    {
        
        

        if (other.collider.tag == "Player")
        {
            Player player = playerObject.GetComponent<Player>();
            player.usePotion(HPget);
            //Debug.Log(ec.currentHealth);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
