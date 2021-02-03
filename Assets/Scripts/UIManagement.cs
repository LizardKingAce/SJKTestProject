using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManagement : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Timer timer;
    public TextMeshProUGUI numLivesText;

    public int stars = 3;
    public List<GameObject> starObjects;

    public GameObject miniMapEndObject;
    private float secondsToWait = .5f;

    void Start()
    {
        Time.timeScale = 1;

        for (int i = 0; i < stars; i++)
        {
            Instantiate(starObjects[stars]);
        }

        StartCoroutine(BlinkOnGoalMesh());
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

    IEnumerator BlinkOnGoalMesh()
    {
        yield return new WaitForSeconds(secondsToWait);
        miniMapEndObject.SetActive(true);
        StartCoroutine(BlinkOffGoalMesh());
    }

    IEnumerator BlinkOffGoalMesh()
    {
        yield return new WaitForSeconds(secondsToWait);
        miniMapEndObject.SetActive(false);
        StartCoroutine(BlinkOnGoalMesh());
    }
}
