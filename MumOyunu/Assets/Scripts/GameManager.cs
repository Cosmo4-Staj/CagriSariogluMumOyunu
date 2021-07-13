using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static bool isGameStarted = false;
    public static bool isGameEnded = false;
    public GameObject finishScreen;
    public GameObject startScreen;
    public GameObject gameOverScreen;
    int LevelCount = 0;
    public Text LevelText;
    public GameObject[] Levels;

    
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
        isGameStarted = false;
        isGameEnded = false;
        GetLevel();
        //LevelText.text = "Level " + (LevelCount +1).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLevelStarted()
    {
        //isGameStarted = true;
        //startScreen.SetActive(false);
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
    public void NextLevel ()
    {
        LevelCount++;
        PlayerPrefs.SetInt("LevelID", LevelCount); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GetLevel()
    {
        LevelCount = PlayerPrefs.GetInt("LevelID", 0); 
        if (LevelCount> Levels.Length -1 || LevelCount <0) 
        {
            LevelCount = 0;
            PlayerPrefs.SetInt("LevelID", LevelCount);
        }
        Instantiate(Levels[LevelCount], Vector3.zero, Quaternion.identity);
    }
}
