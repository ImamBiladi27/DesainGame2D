using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int kecepatan,lompat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
        }
     else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, lompat);
        }
    }
}
