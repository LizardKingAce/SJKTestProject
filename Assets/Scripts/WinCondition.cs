using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinCondition : MonoBehaviour
{
    public GameObject UIPanel;
    public Timer timer;
    public List<GameObject> endStars;

    void Start()
    {
        UIPanel.SetActive(false);
    }

    private void Update()
    {
        if (timer.timeCount >= 180)
        {
            Destroy(endStars[0]);
        }
        else if (timer.timeCount >= 120)
        {
            Destroy(endStars[1]);
        }
        else if (timer.timeCount >= 60)
        {
            Destroy(endStars[2]);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIPanel.SetActive(true);
            timer.timer = false;
        }
    }
}
