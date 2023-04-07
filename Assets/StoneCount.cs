using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoneCount : MonoBehaviour
{
    public static StoneCount instance;
    public TextMeshProUGUI text;
    int scoreStone;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeStone(int stoneValue)
    {
        scoreStone += stoneValue;
        text.text = scoreStone.ToString();
    }
}
