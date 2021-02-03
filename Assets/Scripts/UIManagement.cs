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

    public int stars = 3;
    public List<GameObject> starObjects;

    void Start()
    {
        Time.timeScale = 1;

        for (int i = 0; i < stars; i++)
        {
            Instantiate(starObjects[stars]);
        }
    }

    void Update()
    {
        numLivesText.text = playerHealth.lives.ToString();

        if (timer.timeCount >= 180)
        {
            Destroy(starObjects[0]);
        }
        else if (timer.timeCount >= 120)
        {
            Destroy(starObjects[1]);
        }
        else if (timer.timeCount >= 60)
        {
            Destroy(starObjects[2]);
        }
    }
}

//List.Count

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
