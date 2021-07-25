using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject gameScreen, pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
        gameScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1f;
        gameScreen.SetActive(true);
        pauseScreen.SetActive(false);
    }

    public void ReplayButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HomeButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
