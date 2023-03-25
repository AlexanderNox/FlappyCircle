using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ZaRefactoritPotom
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private ScoreCounter _scoreCounter;
        [SerializeField] private TextMeshProUGUI _text;
   
        void Update() //TODO: bruh
        {
            _text.text =  _scoreCounter.Score.ToString();        
        }
    }
}
