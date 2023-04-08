using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class foodCount : MonoBehaviour
{
    public static foodCount instance;
    public TextMeshProUGUI text;

    void Start()
    {
        text.text = Stage.stones.ToString();
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeFood(int foodValue)
    {
        Stage.foods++;
        text.text = Stage.foods.ToString();
    }
}
