using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
   public Text counterText;
   public int count;
    void Update()
    {
        counterText.text = count.ToString();        
    }
}
