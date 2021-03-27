using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public Health HealthPlayer;
    public string SecondLevel;
    public string FirstLevel;
    public enum GameStates
    {
        Playing,
        GameOver
    }
    private GameStates gameState = GameStates.Playing;
    void Start()
    {
        GameOverCanvas.SetActive(false);
        MainCanvas.SetActive(true);
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        HealthPlayer = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!HealthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                break;
                /*
            case GameStates.GameOver:
                break;
            default:
                break;*/
        }
    }
}
