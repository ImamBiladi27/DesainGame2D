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
    private bool moveLeft;
    private bool moveRight;
    public float horizontalMove;
    public float speed = 5;
    public float jumpSpeed;
    public GameObject Endscrn;
    public string x;
    private Vector3 respawnPoint;
    // public CharacteController2D controller;


    /*public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;


    public float yValue = 1f; // perkiraan posisi muncul peluru pada y
    public float xValue = 0.2f; // perkiraan posisi muncul peluru pada x

    public float bulletPos; //posisi arah terbang peluru ada di kanan atau kiri
    public GameObject shootPos; //letak munculnya peluru terhadap gameobject

    public Rigidbody2D bulletPrefab; //objek peluru yg dimaksud
    */
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        moveLeft = false;
        moveRight = false;
        jumpSpeed = 6f;
       // bulletPos = 1;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;

    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }
    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }
    // Update is called once per frame
    void Update()
    {

        MovementPlayer();
        /* bool shoot = CrossPlatformInputManager.GetButtonDown("Jump"); //ambil nilai kontrol untuk tombol jump

         if (Time.time >= coolDown) //cooldown tembakan
         {
             if (shoot) //jika button ditekan
             {
                 Fire();
             }
         }*/
      //  Input.GetAxisRaw("Horizontal");
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Cube2");
        if (col.gameObject.tag == "Cube3")
        {
            Destroy(col.gameObject);
            Endscrn.gameObject.SetActive(true);
        }
    }
    private void MovementPlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
        }
        else if (moveRight)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
    }
    public void jumpButton()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }
    public void Dash()
    {
        rb.velocity = Vector2.right * jumpSpeed;
    }
    public void jalan_kanan()
    {

        
            transform.position += Vector3.right * (speed*Time.deltaTime);
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    /*void Fire()
    {
        //memunculkan peluru pada posisi gameobject shootpos
        Rigidbody2D bPrefab = Instantiate(bulletPrefab, shootPos.transform.position, shootPos.transform.rotation) as Rigidbody2D;
        //memberikan dorongan peluru sebesar bulletSpeed dengan arah terbangnya bulletPos 
        bPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletPos * bulletSpeed, 0));
        //counting cooldown, nanti dicek lagi
        coolDown = Time.time + attackSpeed;
    }*/
}
