using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.position);
        if(distance > 2)
            lookToPlayer();
    }

    void lookToPlayer()
    {
        Vector3 relativePos = player.position - transform.position;
        Quaternion rotationTarget = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0, rotationTarget.y, rotationTarget.z, rotationTarget.w), 2f * Time.deltaTime);
        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}
