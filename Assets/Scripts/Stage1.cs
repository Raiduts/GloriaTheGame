using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1 : MonoBehaviour
{
    public static int woods;
    public static int stones;
    public static int foods;

    void Update()
    {
        if (woods >= 5 && stones >= 5 && foods >=5)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}
