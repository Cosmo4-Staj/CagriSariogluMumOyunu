using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleScale : MonoBehaviour
{
    public GameObject YouWinScreen;
    public GameObject GameOverScreen;
    public bool OnGround = false;
    public float meltSpeed = 0.2f;
    public float bridgeMeltSpeed = 0.5f;

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
            transform.localScale -= Vector3.up * Time.deltaTime * meltSpeed; // Kuculmeye devam et
        }
        else{

            //bridgeMeltSpeed =0;
            //meltSpeed = 0;
            Time.timeScale=0;
            GameOverScreen.SetActive(true);
        }
    }
    public void GetPartOfMum()
    {
        this.transform.localScale += Vector3.up * 0.2f; // Y ekseninde yukselme islemi
    }
    public void Cutter()
    {
        this.transform.localScale -= Vector3.up * 0.3f;
    }
    public void bridge()
    {
        this.transform.localScale -= Vector3.up * Time.deltaTime * bridgeMeltSpeed;
    }
    public void FinishPad()
    {
        Time.timeScale=0;
        YouWinScreen.SetActive(true);
    }    
}