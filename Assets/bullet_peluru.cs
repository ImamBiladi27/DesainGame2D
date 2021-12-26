using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_peluru : MonoBehaviour
{
    public int lifetime = 2;
    private float timer;
    
    // Start is called before the first frame update
    /*[SerializeField]
    float destroyTime = 2f;
    void Start()
    {
       // Destroy(gameObject, destroyTime);
    }*/
    /*void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(12f, GetComponent<Rigidbody2D>().velocity.y);
       OnCollisionEnter2D
    }*/
    void OnCollisionEnter2D(Collision2D target)
    {
        //Update();
        if (target.gameObject.tag == "SmallStump")
        {
            Destroy(target.gameObject);
        }
        Destroy(gameObject);
    
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(12f, GetComponent<Rigidbody2D>().velocity.y);
        timer += Time.deltaTime;
     if (timer > lifetime)
     {
         timer = 0;
         Destroy(gameObject);
     }
    }
    /* void Update()
     {
         //Destroy(gameObject, destroyTime);
         GetComponent<Rigidbody2D>().velocity = new Vector2(12f, GetComponent<Rigidbody2D>().velocity.y);

     }*/



}
