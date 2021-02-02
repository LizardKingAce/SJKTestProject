using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManagement : MonoBehaviour
{
    //public GameObject pausePanel;
    public PlayerHealth playerHealth;
    public Timer timer;
    public TextMeshProUGUI numLivesText;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    void Start()
    {
        Time.timeScale = 1;
        //pausePanel.SetActive(false);
    }

    void Update()
    {
        numLivesText.text = playerHealth.lives.ToString();

        if (timer.timeCount >= 60)
        {
            Destroy(star1);
        }

        if(timer.timeCount == 120)
        {
            Destroy(star2);
        }

        if(timer.timeCount == 180)
        {
            Destroy(star3);
        }
    }
}



/*public void PauseGame()
{
    if (Time.timeScale == 1)
    {
        Time.timeScale = 0;
        //pausePanel.SetActive(true);
    }
    else if (Time.timeScale == 0)
    {
        Time.timeScale = 1;
        //pausePanel.SetActive(false);
    }

    //in update
            if (Input.GetKeyDown(KeyCode.P))
        {
            PauseGame();
        }


} */
