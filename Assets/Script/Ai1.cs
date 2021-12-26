using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 public class Ai1 : MonoBehaviour
{

    public GameObject Endscrn1;
    float dirX;
    [SerializeField]
    float moveSpeed = 10f;
    Rigidbody2D rb;
    bool facingRight = false;
    Vector3 localScale;
    

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX =1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -9f)

            dirX = 1f;
        else if (transform.position.x > 9f)
            dirX = 1f;
      
       
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
    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "BigStump":
                rb.AddForce(Vector2.up * 1150f);
                
                break;
            case "Enemy":
                rb.AddForce(Vector2.up * 0f);
                break;
            case "NestStump":
                rb.AddForce(Vector2.up * 1050f);
                break;
        }
        Debug.Log("Cube");
        if (col.gameObject.tag == "Cube2")
        {
            //Destroy(col.gameObject);
            Endscrn1.gameObject.SetActive(true);
            move3.SPEED = 0;
            move3.jumpSpeed=0;
            moveSpeed = 0;
            Ai.speed = 0;
        }

    }
    
       
    
    public void Ulang()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Lanjut()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Ulang2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Lanjut2()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Ulang3()
    {
        SceneManager.LoadScene("Level3");
    }
}
