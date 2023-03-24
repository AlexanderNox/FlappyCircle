using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private Text _scoreText;
   
    void Update()
    {
        _scoreText.text =  scoreCounter.score.ToString();        
    }
}
