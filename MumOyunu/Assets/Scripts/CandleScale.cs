using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleScale : MonoBehaviour
{
    public bool OnGround = false;
    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }
    public static CandleScale instance;
  
    void Update()
    {
        if(OnGround) // Yol'un ustundeyse;
        {
            this.transform.localScale -= Vector3.up * Time.deltaTime * 0.2f; // Kuculmeye devam et
        }
    }
    public void GetPartOfMum()
    {
        this.transform.localScale += Vector3.up * 0.2f; // Y ekseninde yukselme islemi
    }
}