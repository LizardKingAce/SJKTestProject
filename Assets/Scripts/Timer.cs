using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [HideInInspector]
    public bool timer;
    [HideInInspector]
    public float timeCount;
    [HideInInspector]
    public float minutes;
    [HideInInspector]
    public float seconds;
    [HideInInspector]
    public float bestMinute;
    [HideInInspector]
    public float bestSecond;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI endTimerText;
    public TextMeshProUGUI bestTimeTextWin;

    public PlayerHealth playerHealth;

    private void Start()
    {
        timer = true;

        if (!PlayerPrefs.HasKey("BestTime"))
        {
            PlayerPrefs.SetFloat("BestTime", Mathf.Infinity);
        }
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
        minutes = Mathf.FloorToInt(timeToDisplay / 60);
        seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        endTimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        bestTimeTextWin.text = FormatTime(PlayerPrefs.GetFloat("BestTime"));
    }

    public string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void CalculateNewHighscore()
    {
        if (PlayerPrefs.GetFloat("BestTime", Mathf.Infinity) > timeCount)
        {
            PlayerPrefs.SetFloat("BestTime", timeCount);
        }

        //Debug.Log("The best time is:" + FormatTime(PlayerPrefs.GetFloat("BestTime", Mathf.Infinity)));
    }
}
