﻿
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 20f;

    public GameObject CompleteLevelUI;
    public GameObject ScoreBoardUI;
    public GameObject PlayGameUI;
    public GameObject GroundUi;
    public GameObject GoldUI;
    public GameObject ScoreUI;
    public GameObject BlockUI;
   // public GameObject GoldCoinUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        PlayGameUI.SetActive(false);
        ScoreBoardUI.SetActive(true);
        //GoldScoreScript.coinAmount = 0;
    }


public void EndGame()
    {
        if (gameHasEnded == false)
        {

           
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            GoldScoreScript.coinAmount = 0;
            ScoreBoardUI.SetActive(true);
            PlayGameUI.SetActive(false);
            //GroundUi.SetActive(false);
            GoldUI.SetActive(false);
            ScoreUI.SetActive(false);
            BlockUI.SetActive(false);
            gameHasEnded = true;
            //GoldCoinUI.SetActive(false);





        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
