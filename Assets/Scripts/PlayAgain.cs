using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour {

   // public static bool Playeractive = false;
    public GameObject PlayGameUI;
    public GameObject PlayMenuUI;
    public GameObject PlayAgainUI;
    public float restartDelay = 20f;

    public void Playgame()
    {
        Invoke("Restart", restartDelay);
        PlayGameUI.SetActive(true);
        //Playeractive = true;
        PlayMenuUI.SetActive(false);
        PlayAgainUI.SetActive(false);
        GoldScoreScript.coinAmount = 0;

    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Quit()
    {
        Debug.Log("QUIT GAME!");
        Application.Quit();

    }
}
