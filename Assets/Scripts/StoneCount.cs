using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoneCount : MonoBehaviour
{
    public static StoneCount instance;
    public TextMeshProUGUI text;
    static int score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeStone(int stoneValue)
    {
        score += stoneValue;
        Stage1.stones = score;
        text.text = score.ToString();
    }
}
