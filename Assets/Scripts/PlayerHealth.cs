using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject startingPoint;
    public Transform playerTran;
    public int lives = 3;

    private void Start()
    {
        playerTran = gameObject.GetComponent<Transform>();
    }

    public void MinusLife(int amount)
    {
        lives -= amount;
        playerTran.position = startingPoint.transform.position;
    }

    public void RestartLevel()
    {
        //reset to start position
    }
}
