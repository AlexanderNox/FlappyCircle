using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
   [SerializeField] Text _counterText;
   public int count;
    void Update()
    {
        _counterText.text = count.ToString();        
    }
}
