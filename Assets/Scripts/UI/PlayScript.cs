using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScript : MonoBehaviour { 

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ResetWaves()
    {
        PlayerPrefs.SetInt("waveNumber", 0);
        PlayerPrefs.SetInt("Tier1", 0);
        PlayerPrefs.SetInt("Tier2", 0);
        PlayerPrefs.SetInt("Tier3", 0);
        PlayerPrefs.SetInt("Tier4", 0);
        PlayerPrefs.SetInt("Tier5", 0);

        PlayerPrefs.SetInt("maxHealth", 10);
        PlayerPrefs.SetInt("fireRate", 12);
        PlayerPrefs.SetInt("bulletSpeed", 20);
        PlayerPrefs.SetInt("moveSpeed", 12);
        PlayerPrefs.SetInt("cashDrop", 0); 

       PlayerPrefs.SetInt("cashAmount",0);
    }
}
