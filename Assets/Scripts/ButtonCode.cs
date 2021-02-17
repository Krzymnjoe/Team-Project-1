using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCode : MonoBehaviour
{
    public Text WinLose;

    public bool win;
    public bool lose;

    void Start()
    {
        WinLose.text = "";

        win = false;
        lose = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 0;
            WinLose.text = "You Lose! \n \n Press R to Return to \n the Main Menu \n or Escape to Quit";
            lose = true;

            if (lose == true)
            {
                FindObjectOfType<MusicSwitch>().DMusic();
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 0;
            WinLose.text = "You Win! \n \n Press R to Restart to \n the Main Menu \n or Escape to Quit";
            win = true;

            if (win == true)
            {
                FindObjectOfType<MusicSwitch>().VMusic();
            }

        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

        }

        if (Time.timeScale == 0)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);

            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();

            }

        }
    }
        public void QuitGame()
        {
            Application.Quit();
            Debug.Log("Game is exiting");
        }

        public void NextLevelButton(int index)
        {
            SceneManager.LoadScene(index);
        }

        public void QuitGame(string Game)
        {
            Application.Quit();
        }

    
}
