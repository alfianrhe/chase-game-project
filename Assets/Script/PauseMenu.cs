using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PauseMenu : MonoBehaviour
    {

        public static bool GameIsPaused = false;
        public GameObject pauseMenu;
        public GameObject gameCanvas;


    // Update is called once per frame
    private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
        
        public void Resume()
        {
            pauseMenu.SetActive(false);
            gameCanvas.SetActive(true);
            Time.timeScale = 1f;
            GameIsPaused = false;

        }

        public void Pause()
        {
            pauseMenu.SetActive(true);
            gameCanvas.SetActive(false);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }
