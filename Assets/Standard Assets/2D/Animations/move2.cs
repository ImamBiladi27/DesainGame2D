using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
//using CodeMonkey.Utils;
public class move2 : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    private float moveSpeed;
    public float dash = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {

 

    }
    public void DashButton()
    {
        rb.velocity = Vector2.right * dash;
    }
}
