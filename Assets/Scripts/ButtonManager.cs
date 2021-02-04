using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

    public void OnRestarButtonClick()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void Quit()
    {

        Application.Quit();
    }
}
