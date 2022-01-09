using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    GameObject player;
    public float distanceLimit;
    private float Distance;
    public float enemyAttackCooldown;
    private float timer;

    public int enemyAttack;
    private bool AttackAvailable = true;

    public Animation damageAnim;
    // Start is called before the first frame update
    void Start()
    {
        timer = enemyAttackCooldown;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance();
        CooldownAttack();
    }

    void playerDistance()
    {
        Distance = Vector3.Distance(transform.position, player.transform.position);

        Debug.DrawLine(transform.position, player.transform.position);
        //Debug.Log(Distance);
        if (Distance<distanceLimit)
        {
            Debug.DrawLine(transform.position, player.transform.position,new Color(255,0,0));
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player" && AttackAvailable)
        {
            //Debug.Log("Haha");
            Player HP;
            HP = player.GetComponent<Player>();
            HP.health -= enemyAttack;
            damageAnim.Play("Kedamage");
            //Debug.Log(HP.health);
            AttackAvailable = false;
            //Debug.Log("Attack Available " + AttackAvailable);
        }
    }

    void CooldownAttack()
    {
        if (!AttackAvailable)
        {
            timer -= Time.deltaTime;
            if(timer<0)
            {
                AttackAvailable = true;
                timer = enemyAttackCooldown;
                //Debug.Log("Attack Available " + AttackAvailable);
            }
        }
    }
}
