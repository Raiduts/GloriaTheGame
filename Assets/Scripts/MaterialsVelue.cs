using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaterialsVelue : MonoBehaviour
{
    public TextMeshProUGUI textWoods;
    public TextMeshProUGUI textStones;
    public TextMeshProUGUI textFoods;

    void Update()
    {
        textWoods.text = SaveData.woods.ToString();
        textStones.text = SaveData.stones.ToString();
        textFoods.text = SaveData.foods.ToString();
    }
}
