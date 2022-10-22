using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;
    int lives = 3;
    bool gameOver = false;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;
            print(lives);
        }
        else
        {
            gameOver = true;
        }
    }

    public void GameOver()
    {
        print("Game Over!");
    }
}
