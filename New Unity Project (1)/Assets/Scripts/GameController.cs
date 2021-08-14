using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject cmv;
    public GameObject gme;
    public int score = 0;

    public void Start()
    {
        Time.timeScale = 1;
    }
    
    public void gameover()
    {
        gme.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }
    public void play()
    {
        SceneManager.LoadScene(0);
        
        
    }
    public void exit()
    {
        Application.Quit();
    }


}
