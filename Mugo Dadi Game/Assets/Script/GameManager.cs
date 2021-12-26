using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isPlaying = true;
    public int jumlahEnemy;
    public GameObject gameOverText;

    public int limitPotionDrop;

    private int playerKill = 0;

    private int currentKill=0;
    public Text killsText;
    // Start is called before the first frame update
    void Start()
    {
        killsText.text = "Kill's : " + playerKill.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPlaying)
        {
            GameOverAnim anim = gameOverText.GetComponent<GameOverAnim>();
            anim.showGameOver();
            //Time.timeScale = 0;
        }
    }

    public bool getPlaying()
    {
        return isPlaying;
    }

    public void playerDead()
    {
        isPlaying = false;
    }

    public void addScore()
    {
        playerKill += 1;
        killsText.text = "Kill's : " + playerKill.ToString(); 
    }

    public int getCurrentKill()
    {
        currentKill++;
        return currentKill;
    }

    public int resetCurrentKill()
    {
        currentKill = 0;
        return currentKill;
    }
}
