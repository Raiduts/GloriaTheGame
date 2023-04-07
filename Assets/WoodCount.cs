using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodCount : MonoBehaviour
{
    public static WoodCount instance;
    public TextMeshProUGUI text;
    int scoreWood;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeWood(int woodValue)
    {
        scoreWood += woodValue;
        text.text = scoreWood.ToString();
    }
}
