using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;
    public float pointsPerSecond;
   // public GameObject player;
    public bool scoreIncreasingl;
    public int a;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasingl)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        else if (a==1)
        {
            scoreCount -= pointsPerSecond * Time.deltaTime;
            Debug.Log("kurang1");
        }
      
        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }

        scoreText.text="Score: "+(int)scoreCount;
        hiScoreText.text = "High Score: " + (int)hiScoreCount;

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "BigStump")
        {
            a += 1;
            Update();
        }

    }
}
