using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    private float moveSpeed;
    public GameObject Endscrn;
    // Start is called before the first frame update
   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
    }
   
    // Update is called once per frame
   private void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
      //  rb.velocity = new Vector2(dirX, 0f);
     
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
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }
 
}
