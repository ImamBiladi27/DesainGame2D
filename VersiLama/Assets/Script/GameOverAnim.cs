using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAnim : MonoBehaviour
{
    public Animator animatorGameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showGameOver()
    {
        animatorGameOver.SetBool("gameOver", true);
    }

    public void endgame()
    {
        Time.timeScale = 0;
    }
}
