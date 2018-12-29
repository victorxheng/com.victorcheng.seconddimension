using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Settings : MonoBehaviour {
    public TextMeshProUGUI musicText;
    public TextMeshProUGUI soundEffectsText;
    public TextMeshProUGUI effectsText;
    public DontDestroyAudio da;
    

    public void onStart()
    {
        if(PlayerPrefs.GetInt("music", 1) == 1)
        {
            musicText.text = "MUSIC: ON";
        }
        else
        {
            musicText.text = "MUSIC: OFF";
        }

        if (PlayerPrefs.GetInt("soundEffects", 1) == 1)
        {
            soundEffectsText.text = "SOUND EFFECTS: ON";
        }
        else
        {
            soundEffectsText.text = "SOUND EFFECTS: OFF";
        }


        if (PlayerPrefs.GetInt("effects", 1) == 1)
        {
            effectsText.text = "GRAPHIC EFFECTS: ON";
        }
        else
        {
            effectsText.text = "GRAPHIC EFFECTS: OFF";
        }     

    }

    public void onMusic()
    {
        if (PlayerPrefs.GetInt("music", 1) == 1)
        {
            PlayerPrefs.SetInt("music", 0);
            musicText.text = "MUSIC: OFF";
            da.musicOff();
        }
        else
        {
            PlayerPrefs.SetInt("music", 1);
            musicText.text = "MUSIC: ON";
            da.musicOn();
        }
    }

    public void onSound()
    {
        if (PlayerPrefs.GetInt("soundEffects", 1) == 1)
        {
            PlayerPrefs.SetInt("soundEffects", 0);
            soundEffectsText.text = "SOUND EFFECTS: OFF";
        }
        else
        {
            PlayerPrefs.SetInt("soundEffects", 1);
            soundEffectsText.text = "SOUND EFFECTS: ON";
        }
    }
    public void onEffects()
    {
        if (PlayerPrefs.GetInt("effects", 1) == 1)
        {
            PlayerPrefs.SetInt("effects", 0);
            effectsText.text = "GRAPHIC EFFECTS: OFF";
        }
        else
        {
            PlayerPrefs.SetInt("effects", 1);
            effectsText.text = "GRAPHIC EFFECTS: ON";
        }
    }

}
