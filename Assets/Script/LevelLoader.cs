using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car
{
    public class LevelLoader : MonoBehaviour
    {
        public GameObject loadingScreen;
        public GameObject otherScreen;
        public Slider progressBar;
        public Text progressText;

        public void LoadLevel(int sceneIndex)
        {
            // Start loading a scene
            StartCoroutine(LoadAsynchronously(sceneIndex));

            // Start game if game is freeze
            if (PauseMenu.GameIsPaused)
            {
                Time.timeScale = 1f;
            }
        }


        // Load a Scene based on Index from Build Setting Asyncronously
        IEnumerator LoadAsynchronously(int sceneIndex)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

            otherScreen.SetActive(false);
            loadingScreen.SetActive(true);

            // Set a progress bar
            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / .9f);

                progressBar.value = progress;
                progressText.text = progress * 100f + "";

                yield return null;
            }
        }
    }
}