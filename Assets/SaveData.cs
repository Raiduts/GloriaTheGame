using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static int woods;
    public static int stones;
    public static int foods;

    void Start()
    {
        Load();
    }

    public static void Save()
    {
        PlayerPrefs.SetInt("WoodsValue", woods);
        PlayerPrefs.SetInt("StonesValue", stones);
        PlayerPrefs.SetInt("FoodsValue", foods);
    }

    public void Load()
    {
        woods = PlayerPrefs.GetInt("WoodsValue", woods);
        stones = PlayerPrefs.GetInt("StonesValue", stones);
        foods = PlayerPrefs.GetInt("FoodsValue", foods);
    }

}
