using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static bool isGameStarted = false;
    public static bool isGameEnded = false;
    public GameObject finishScreen;
    public GameObject gameOverScreen;
    public GameObject startScreen;


    private void Awake()
    {        
        if (instance == null)
        {
            instance = this;
        }
    }

     // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLevelStarted()
    {

    }
    public void OnLevelEnded() // Game Over?
    {
        
    }
    public void OnLevelCompleted() // Loads the next level
    {
        CandleScale.instance.bridgeMeltSpeed=0;
        CandleScale.instance.meltSpeed=0;
        CandleScale.instance.speed = 0;
        finishScreen.SetActive(true);
        isGameEnded = true;
    }

    public void OnLevelFailed() // Loads the current scene back on collision with an obstacle.
    {
        CandleScale.instance.bridgeMeltSpeed=0;
        CandleScale.instance.meltSpeed=0;
        CandleScale.instance.speed = 0;
        gameOverScreen.SetActive(true);
        isGameEnded = true;
    }
    public void Restart ()
    {
        SceneManager.LoadScene("Game");
    }

   
}
