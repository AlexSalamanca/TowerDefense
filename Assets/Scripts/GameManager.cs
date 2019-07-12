using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool gameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.lives <= 0)
        {
            if (gameOver) return;
            else EndGame();
        }
    }

    void EndGame()
    {
        gameOver = true;
        Debug.Log("Game Over!");
    }
}