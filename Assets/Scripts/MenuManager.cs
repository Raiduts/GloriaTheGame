using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public int gameStartScene;

    public void Resume()
    {
        SceneManager.LoadScene(gameStartScene);
        SaveData.Load();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(gameStartScene);
        SaveData.NewGame();
    }
}
