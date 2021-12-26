using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int lifetime = 2;
    private float timer;

    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "char2")
        {
            Hati3.health -= 1;
        }
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifetime)
        {
            timer = 0;
            Destroy(gameObject);
        }
    }
}
