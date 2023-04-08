using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class foodCount : MonoBehaviour
{
    public static foodCount instance;
    public TextMeshProUGUI text;
    static int score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeFood(int foodValue)
    {
        score += foodValue;
        Stage1.foods = score;
        text.text = score.ToString();
    }
}
