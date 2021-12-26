using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour
{
    /*  Rigidbody2D rb;
      //public GameObject peluru, pos_peluru;
      // Start is called before the first frame update
      [SerializeField]
      public Rigidbody2D bullet;
      public Transform barrel;
      float bulletSpeed = 500f;
      Vector3 localScale;
      public GameObject peluru, pos_peluru;
      void Start()
      {
          //localScale = transform.localScale;
          //rb = GetComponent<Rigidbody2D> ();
      }
      void OnMouseDown()
      {
          Instantiate(peluru, pos_peluru.transform.position, pos_peluru.transform.rotation);
      }

      // Update is called once per frame
     // void Update()
     // {

   //   }
      /*void Fire()
      {
          var firedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
          firedBullet.AddForce(barrel.up * bulletSpeed);
      }*/
    /* bool facingRight = true;
     public GameObject bullet;
     Vector2 bulletPos;
     public float fireRate = 0.5f;
     float nextFire = 0.0f;

     void Start()
     {
         if (Input.GetButtonDown("Fire1")&& Time.time > nextFire)
         {
             nextFire = Time.time + fireRate;
             fire();
         }
     }
     void fire()
     {
         bulletPos = transform.position;
         //if (facingRight)
         //{
         bulletPos += new Vector2(+1f,-0.43f);
         Instantiate(bullet, bulletPos, Quaternion.identity);
         //}
         /*else
         {
             bulletPos += new Vector2(-1f, -0.43f);
             Instantiate(bullet)
         }*/
    //}
    /* float range = 100f;
     public GameObject particlePlayerHitPoint;
     public void ShootGun()
     {
         Shout();
     }
     void Shout()
     {
         Vector3 rayOrigin = transform.position;
         RaycastHit hit;
         if(Physics.Raycast(rayOrigin,transform.forward,out hit, range))
         {
             if (hit.collider.tag == "SmallStump")
             {
                 Instantiate(particlePlayerHitPoint, hit.point, Quaternion.identity);
                 Destroy(hit.collider.gameObject);
             }
         }
     }*/
    public GameObject peluru, pos_peluru;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseDown()
    {
        Instantiate(peluru, pos_peluru.transform.position, pos_peluru.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(12f, GetComponent<Rigidbody2D>().velocity.y);

    }
}
