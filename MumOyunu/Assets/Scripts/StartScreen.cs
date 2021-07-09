using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    //public GameObject.StartScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
        SceneManager.LoadScene("Game");
        //StartScreen.SetActive(false);
    }
}
