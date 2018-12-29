using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Player : MonoBehaviour {

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI cashText;
    public TextMeshProUGUI enemiesText;
    //public TextMeshProUGUI highscoreText;
    //public TextMeshProUGUI prevText;

    public waveFramework wf;
    public activePanel ap;
    public GameObject mp;

    private void Awake()
    {

        //PlayerPrefs.SetInt("playerKills", 0);
        //PlayerPrefs.SetInt("playerHealth", 1000);
        if(PlayerPrefs.GetInt("status", 0) == 1)
        {
            PlayerPrefs.SetInt("playerHealth", PlayerPrefs.GetInt("waveHealth", 10));
            wf.onPlay();
            ap.closeWindow();
            mp.SetActive(false);
        }
        PlayerPrefs.SetInt("status", 0);
        Application.targetFrameRate = 180;
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("playerHealth", 10) < 1)
        {
            // if(PlayerPrefs.GetInt("cashAmount", 0)> PlayerPrefs.GetInt("playerHighscore", 0))
            // {
            //     PlayerPrefs.SetInt("playerHighscore", PlayerPrefs.GetInt("playerKills", 0));
            // }
            //PlayerPrefs.SetInt("previousCash", PlayerPrefs.GetInt("previousCash", 0));

            PlayerPrefs.SetInt("status", 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
        healthText.text = "HEALTH: " + PlayerPrefs.GetInt("playerHealth", 10);
        cashText.text = "CASH: " + PlayerPrefs.GetInt("cashAmount", 0);
        enemiesText.text = "ENEMIES ACTIVE: " + PlayerPrefs.GetInt("enemies", 0);
        // highscoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("playerHighscore", 0);
        // prevText.text = "PREVIOUS SCORE: " + PlayerPrefs.GetInt("previousKills", 0);

    }

}
