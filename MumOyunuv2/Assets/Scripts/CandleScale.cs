using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleScale : MonoBehaviour
{
    public float scale = 1 ; //Başlangıç boyutu
  
    void Update()
    {
        if (scale>=0.03f) //0.03 boyutuna gelene kadar;
        { 
            transform.localScale = new Vector3(1, scale, 1); // Boyutlandırma satırı
            scale = scale-0.008f; // Boyutu 0.008 kadar azalt.
        }
    }
}
