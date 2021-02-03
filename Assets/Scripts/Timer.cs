using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool timer;
    public float timeCount;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI endTimerText;

    private void Start()
    {
        timer = true;
    }

    void Update()
    {
        if (timer == true)
        {
            timeCount += Time.deltaTime;
            DisplayTime(timeCount);
        }
        else
        {
            Time.timeScale = 0;
            timer = false;
        }
    }

    public void DisplayTime (float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        endTimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
