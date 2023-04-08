using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildHouse1 : MonoBehaviour
{

    public GameObject template;
    public GameObject rumah;
    public int woodMaterial;
    public int stoneMaterial;
    public int foodMaterial;

    public void Start()
    {
        rumah.SetActive(false);
    }
    public void Build()
    {
        if (SaveData.woods >= woodMaterial && SaveData.stones >= stoneMaterial && SaveData.foods >= foodMaterial)
        {
            rumah.SetActive(true);
            template.SetActive(false);
            SaveData.woods -= woodMaterial;
            SaveData.stones -= stoneMaterial;
            SaveData.foods -= foodMaterial;
        }
    }
}
