using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {
    public static DontDestroyAudio instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        if (PlayerPrefs.GetInt("music", 1) == 1)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void musicOff()
    {
        gameObject.SetActive(false);
    }
    public void musicOn()
    {
        gameObject.SetActive(true);
    }
    
}
