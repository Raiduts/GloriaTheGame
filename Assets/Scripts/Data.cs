using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public int maxHealth;
    public static int health;

    void Update()
    {
        health = maxHealth;
        if (health <= 0)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }

}
