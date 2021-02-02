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

    private void Start()
    {
        timer = true;
    }

    void Update()
    {
        if (timer)
        {
            timeCount += Time.deltaTime;
            DisplayTime(timeCount);
        }
            /*else
            {
                //SceneManager.LoadScene("Final");
                timeCount = 0;
                timer = false;
            } */
    }

    void DisplayTime (float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
