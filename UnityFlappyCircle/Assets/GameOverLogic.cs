using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLogic : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Barriers")
        {
            GameOver();
        }       
    }

    void OnBecameInvisible()
    {
        GameOver();
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
