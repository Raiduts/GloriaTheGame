using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class foodCount : MonoBehaviour
{
    public static foodCount instance;
    public TextMeshProUGUI text;
    int scoreStone;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeFood(int foodValue)
    {
        scoreStone += foodValue;
        text.text = scoreStone.ToString();
    }
}
