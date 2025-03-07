using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] levelLoader levelLoader;

    // When Play Game button is clicked
    public void LoadScene(int sceneIndex)
    {
        // Move to the next scene
        //levelLoader.LoadNextLevel(sceneIndex); A REMETTRE QUAND TRANSITION FIXED
        SceneManager.LoadScene(sceneIndex);
    }

    // When Quite Game button is clicked
    public void QuitGame()
    {
        // Close the application
        Application.Quit();
    }
}
