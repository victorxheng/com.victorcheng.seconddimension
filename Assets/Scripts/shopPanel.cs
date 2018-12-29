using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopPanel : MonoBehaviour {

    public GameObject panel;
    
    public void openWindow()
    {
        panel.SetActive(true);
        Time.timeScale = 0;//pause
    }
    public void closeWindow()
    {
        Time.timeScale = 1;//unpause
        panel.SetActive(false);
    }
}
