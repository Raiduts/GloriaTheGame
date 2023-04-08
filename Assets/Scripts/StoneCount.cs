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
        text.text = Stage.stones.ToString();
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeStone(int stoneValue)
    {
        Stage.stones++;
        text.text = Stage.stones.ToString();
    }
}
