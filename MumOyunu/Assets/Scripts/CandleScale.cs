using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleScale : MonoBehaviour
{
    GameManager gameManager;
    private Touch touch;
    private float speedModifier;
    public GameObject Piece;
    public static CandleScale instance;
    public float speed = 5;
    public bool OnGround = false;
    public float meltSpeed = 0.2f;
    public float bridgeMeltSpeed = 0.5f;
    Vector3 PiecePos = new Vector3(0f, -0.3f, 0f);

    
    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }
    private void start()
    {
        speedModifier = 0.01f;

    }
    void Update()
    {
        transform.Translate(Vector3.forward * (speed) * Time.deltaTime);// Ileri doğru hareket

        this.transform.localScale -= Vector3.up * Time.deltaTime * meltSpeed; // Kuculmeye devam et

        if(this.transform.localScale.y <= 0.0f)
        {
            GameManager.instance.OnLevelFailed();
        }
    }
    public void GetPartOfMum()
    {
        this.transform.localScale += Vector3.up * 0.2f; // Y ekseninde yukselme islemi
    }
    public void Cutter()
    {
        SpawnPiece();
        //Instantiate(Piece,MumHareket.instance.transform.position - PiecePos,Quaternion.identity);
        this.transform.localScale -= Vector3.up * 0.3f;
    }
    public void bridge()
    {
        this.transform.localScale -= Vector3.up * Time.deltaTime * bridgeMeltSpeed;
    }
    public void FinishPad()
    {
        GameManager.instance.OnLevelCompleted();
    }    
    public void SpawnPiece()
    {
        Instantiate(Piece, MumHareket.instance.transform.position - PiecePos * 1f, Quaternion.identity);
    }
}