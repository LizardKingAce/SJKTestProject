using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManagement : MonoBehaviour
{
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

        if (timer.timeCount >= 90)
        {
            Destroy(starObjects[0]);
        }
        else if (timer.timeCount >= 75)
        {
            Destroy(starObjects[1]);
        }
        else if (timer.timeCount >= 60)
        {
            Destroy(starObjects[2]);
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Game Scene");
        }
    }
}
