using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadlock2 : MonoBehaviour
{
    public GameObject Endscrn1;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Destroy(col.gameObject);
            Endscrn1.gameObject.SetActive(true);
        }
    }
}
