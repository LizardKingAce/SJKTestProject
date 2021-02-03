using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public GameObject startingPoint;
    public Transform playerTran;
    public int lives = 3;
    public GameObject losePanel;



    private void Start()
    {
        playerTran = gameObject.GetComponent<Transform>();
        losePanel.SetActive(false);
    }

    public void MinusLife(int amount)
    {
        lives -= amount;
        playerTran.position = startingPoint.transform.position;

        if(lives == 0)
        {
            losePanel.SetActive(true);
        }
    }

    public void RestartLevel()
    {
        //reset to start position
    }
}
