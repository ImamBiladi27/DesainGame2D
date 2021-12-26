using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sukses : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dipintu1,puyi_bangun;

    void Start()
    {
        
    }
    void OnMouseUp()
    {
        dipintu1.SetActive(true);
        puyi_bangun.SetActive(true);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
