using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int score;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<ScoreGiver>().GiveScore(ref score);
    }
}
