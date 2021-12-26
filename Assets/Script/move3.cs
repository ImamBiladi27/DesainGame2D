using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class move3 : move2
{
    private Rigidbody2D rb;
    public static float jumpSpeed=5f;
    public GameObject Endscrn;
    public static float SPEED = 0.022997f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        base.jalan_kanan();
    }
        void Update()
    {
        if (Hati2.health > 0)
        {

            Vector3 position = transform.position;
            if (Input.GetKey(KeyCode.A))
            {
                position.x -= SPEED;
            }
            if (Input.GetKey(KeyCode.D))
            {
                position.x += SPEED ;
            }
            transform.position = position;
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = Vector2.up * jumpSpeed;
            }
            if (Input.GetKey(KeyCode.F))
            {
                base.jalan_kanan();
            }
        }

    }
}
