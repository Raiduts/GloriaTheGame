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
        text.text = Stage.woods.ToString();
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeWood(int woodValue)
    {
        Stage.woods++;
        text.text = Stage.woods.ToString();
    }
}
