using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static int woods;
    public static int stones;
    public static int foods;
    public static int progress;

    void Start()
    {
    }

    public static void Save()
    {
        PlayerPrefs.SetInt("WoodsValue", woods);
        PlayerPrefs.SetInt("StonesValue", stones);
        PlayerPrefs.SetInt("FoodsValue", foods);
        PlayerPrefs.SetInt("Progress", progress);
    }

    public static void Load()
    {
        woods = PlayerPrefs.GetInt("WoodsValue", woods);
        stones = PlayerPrefs.GetInt("StonesValue", stones);
        foods = PlayerPrefs.GetInt("FoodsValue", foods);
        PlayerPrefs.GetInt("Progress", progress);
    }

    public static void NewGame(){
        PlayerPrefs.SetInt("WoodsValue", 0);
        PlayerPrefs.SetInt("StonesValue", 0);
        PlayerPrefs.SetInt("FoodsValue", 0);
        PlayerPrefs.SetInt("Progress", 0);
    }

}
