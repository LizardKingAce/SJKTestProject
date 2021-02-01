using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;

    public void MinusLife(int amount)
    {
        lives -= amount;
        //RestartLevel();
    }

    public void RestartLevel()
    {
        //reset to start position
    }
}
