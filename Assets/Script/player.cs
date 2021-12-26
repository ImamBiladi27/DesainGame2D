using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    float dirX;
    [SerializeField]
    float moveSpeed = 5f;
    Rigidbody2D rb;
    bool facingRight = false;
    Vector3 localScale;
    public int kecepatan, lompat;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -9f)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * kecepatan * Time.deltaTime);
                dirX = 3f;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.right * -kecepatan * Time.deltaTime);
                dirX = 3f;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, lompat);
                dirX = 3f;
            }
           
        }

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }
    void LateUpdate()
    {
        CheckWhereToFace();
    }
    void CheckWhereToFace()
    {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "BigStump":
                rb.AddForce(Vector2.up * 600f);
                break;
            case "SmallStump":
                rb.AddForce(Vector2.up * 450f);
                break;
        }
    }
}
