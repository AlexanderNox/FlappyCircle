using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGiver : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<ScoreCounter>() != null)
        {
            other.GetComponent<ScoreCounter>().AddScore();
        }
    }
}
