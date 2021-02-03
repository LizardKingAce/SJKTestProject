using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinCondition : MonoBehaviour
{
    public GameObject UIPanel;
    //public Timer timer;
    //public TextMeshProUGUI timerDisplay;

    void Start()
    {
        UIPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIPanel.SetActive(true);
            //timer.DisplayTime(timer.timeCount);
        }
    }
}
