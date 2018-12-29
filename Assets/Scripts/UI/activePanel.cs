using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activePanel : MonoBehaviour {

    public GameObject panel;
    public GameObject parent;
    public GameObject refillHealth;
    Image image;
    bool isActive= false;

    public GameObject button1;
    public GameObject button2;

    private void Start()
    {
        image = panel.GetComponent<Image>();
        colorNormal();
    }
    public void openWindow()
    {
        panel.SetActive(true);
        parent.SetActive(true);
        if (refillHealth.active)
        {
            refillHealth.SetActive(false);
            isActive = true;
        }
        else
        {
            isActive = false;
        }
        button1.SetActive(false);
        button2.SetActive(false);
        Time.timeScale = 0;//pause
    }
    public void closeWindow()
    {
        Time.timeScale = 1;//unpause
        panel.SetActive(false);
        parent.SetActive(false);

        button1.SetActive(true);
        button2.SetActive(true);

        if (isActive)
        {
            refillHealth.SetActive(true);
            isActive = false;
        }
    }
    public void colorNormal()
    {
        image.color = new Color(0, 0, 0, 0.2f);
    }
    public void colorDark()
    {
        image.color = new Color(0, 0, 0, 0.9f);
    }
}
