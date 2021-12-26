using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class char1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public int kecepatan, lompat;
    public GameObject Endscrn;
    public float speed;
     private float moveInput;
    [Header("References")]
    public Rigidbody2D rb;
    public float dashForce;
    private bool isDashing;
    public float dashTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
   /*public void jalan_kanan()
    {
        transform.position += transform.right * (Time.deltaTime * 10);

    }
    public void jalan_kiri()
    {
        transform.position -= transform.right * (Time.deltaTime * 10);

    }*/

    // Update is called once per frame
    public void Update()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            jalan_kiri();
        }

        else if (Input.GetKey(KeyCode.D))
        {
            jalan_kanan();
        }*/


        if (Input.GetMouseButton(0))
        {
                      StartCoroutine(Dash());
        }
    }
     void FixedUpdate()
    {
        if (!isDashing)
        {
            rb.velocity = new Vector2(moveInput * kecepatan, rb.velocity.y);

        }
        else
        {
            rb.velocity = Vector2.right * dashForce;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Cube");
        if (col.gameObject.tag == "Cube")
        {
            Destroy(col.gameObject);
            Endscrn.gameObject.SetActive(true);
        }
    }
    
    public void NextButtonClicked()
    {
        SceneManager.LoadScene("Level2");
    }

    IEnumerator Dash()
    {
        isDashing = true;
        yield return new WaitForSeconds(dashTime);
        isDashing = false;

    }
}
