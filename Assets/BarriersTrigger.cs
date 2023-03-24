using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarriersTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<GameOverLogic>() != null)
        {
            other.gameObject.GetComponent<GameOverLogic>().GameOver();
        }       
    }
}
