using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;
    public static int numberOfCoins,numberOfTurretsDestroyed,numberOfGatesPassed;
    public static float health,score;
    public Text coinsText;
    public Text turretsText;
    public Text gatesText;
    public Text healthText;
    public Text scoreText;

    
    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isGameStarted = false;
        numberOfCoins = 0;
        numberOfTurretsDestroyed = 0;
        numberOfGatesPassed = 0;
        health = 200;
        score = 0;


        // InvokeRepeating("fpsChecker",0,1);
    }
    

    void Update()
    {
        if(gameOver){
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            score = numberOfCoins*50 + numberOfTurretsDestroyed*1000 + numberOfGatesPassed*100;
            scoreText.text = "Score: " + score;
        }
        coinsText.text = "Coins: " + numberOfCoins;
        turretsText.text = "Turrets: " + numberOfTurretsDestroyed;
        gatesText.text = "Gates: " + numberOfGatesPassed;
        healthText.text = "Health: " + health;

        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }

    void fpsChecker()
    {
        Debug.Log(1/Time.deltaTime);
    }
}
