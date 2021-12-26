using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy: MonoBehaviour
{
    public GameObject Enemy;
    public GameObject gameHandler;
    public float timerSpawn;

    private float X, Y, Z;
    private float timerSpawn2;

    public bool isGameStart;

    public int EnemyLimit;

    // Start is called before the first frame update
    void Start()
    {
        isGameStart = true;
        resetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameStart)
        {
            timerSpawn2 -= Time.deltaTime;

            if (timerSpawn2 < 0)
            {
                randomSpawn();
                resetTimer();
            }
        }
        
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    void randomSpawn()
    {
        float minX = transform.position.x - (transform.localScale.x / 2);
        float maxX = transform.position.x + (transform.localScale.x / 2);

        float minZ = transform.position.z - (transform.localScale.z / 2);
        float maxZ = transform.position.z + (transform.localScale.z / 2);

        X = Random.Range(minX, maxX);
        Y = transform.position.y + 0.5f;
        Z = Random.Range(minZ, maxZ);

        Vector3 spawnCoor = new Vector3(X, Y, Z);
        Quaternion spawnRot = Quaternion.Euler(0, 0, 90);

        GameManager gameManager;
        gameManager = gameHandler.GetComponent<GameManager>();
        if (gameManager.jumlahEnemy < EnemyLimit)
        {


            GameObject EnemyClone = Instantiate(Enemy, spawnCoor, spawnRot);

            gameManager.jumlahEnemy++;
           // Debug.Log("Jumlah Enemy " + gameManager.jumlahEnemy);


            //Destroy(coinClone, 4f);
        }
    }

    void resetTimer()
    {
        timerSpawn2 = timerSpawn;
    }
}
