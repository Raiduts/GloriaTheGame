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
    }
    public void QuitGame()
    {
        SaveData.Save();
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(gameStartScene);
        SaveData.NewGame();
    }
}
