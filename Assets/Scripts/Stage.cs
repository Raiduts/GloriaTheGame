using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour
{
    public int woodNeeded;
    public int stoneNeeded;
    public int foodNeeded;
    public static int woods;
    public static int stones;
    public static int foods;

    void Start(){
        woods = 0;
        stones = 0;
        foods = 0;
    }

    void Update()
    {
        if (woods >= woodNeeded && stones >= stoneNeeded && foods >= foodNeeded)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
            SaveData.woods += woods;
            SaveData.stones += stones;
            SaveData.foods += foods;
            SaveData.progress += 1;
            SaveData.Save();
        }
    }
}
