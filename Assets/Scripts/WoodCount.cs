using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodCount : MonoBehaviour
{
    public static WoodCount instance;
    public TextMeshProUGUI text;
    static int score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeWood(int woodValue)
    {
        score += woodValue;
        Stage1.woods = score;
        text.text = score.ToString();
    }
}
