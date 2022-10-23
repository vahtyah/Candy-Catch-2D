using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject livesHolder;
    public GameObject gameOverPanel;

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
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;
            print(lives);
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }
        if(lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawningScandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
        print("Game Over!");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
