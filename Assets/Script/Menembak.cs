using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Menembak : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpSpeed;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;


    public float yValue = 1f; // perkiraan posisi muncul peluru pada y
    public float xValue = 0.2f; // perkiraan posisi muncul peluru pada x

    public float bulletPos; //posisi arah terbang peluru ada di kanan atau kiri
    public GameObject shootPos; //letak munculnya peluru terhadap gameobject

    public Rigidbody2D bulletPrefab; //objek peluru yg dimaksud
    private bool Shoot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpSpeed = 6f;
        bulletPos = 1;
        //Shoot = false;
    }
    // Update is called once per frame
    void Update()
    {
        float h = CrossPlatformInputManager.GetAxis("Horizontal"); //ambil nilai kontrol untuk gerakan horizontal
        float v = CrossPlatformInputManager.GetAxis("Vertical");
        bool shoot = CrossPlatformInputManager.GetButtonDown("Jump"); //ambil nilai kontrol untuk tombol jump

        if (Time.time >= coolDown) //cooldown tembakan
        {
            if (shoot) //jika button ditekan
            {
                Fire();
            }
        }

    }

    void Fire()
    {
        //memunculkan peluru pada posisi gameobject shootpos
        Rigidbody2D bPrefab = Instantiate(bulletPrefab, shootPos.transform.position, shootPos.transform.rotation) as Rigidbody2D;
        //memberikan dorongan peluru sebesar bulletSpeed dengan arah terbangnya bulletPos 
        bPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletPos * bulletSpeed, 0));
        //counting cooldown, nanti dicek lagi
        coolDown = Time.time + attackSpeed;
    }
}
