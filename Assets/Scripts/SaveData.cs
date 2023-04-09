using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static int woods;
    public static int stones;
    public static int foods;
    public static int progress;
    public static int rumah;

    void Start()
    {

    }

    public static void Save()
    {
        PlayerPrefs.SetInt("WoodsValue", woods);
        PlayerPrefs.SetInt("StonesValue", stones);
        PlayerPrefs.SetInt("FoodsValue", foods);
        PlayerPrefs.SetInt("Progress", progress);
        PlayerPrefs.SetInt("Rumah",rumah);
    }

    public static void Load()
    {
        woods = PlayerPrefs.GetInt("WoodsValue", woods);
        stones = PlayerPrefs.GetInt("StonesValue", stones);
        foods = PlayerPrefs.GetInt("FoodsValue", foods);
        progress = PlayerPrefs.GetInt("Progress", progress);
        rumah = PlayerPrefs.GetInt("Rumah",rumah);
    }

    public static void NewGame(){
        PlayerPrefs.SetInt("WoodsValue", 0);
        PlayerPrefs.SetInt("StonesValue", 0);
        PlayerPrefs.SetInt("FoodsValue", 0);
        PlayerPrefs.SetInt("Progress", 0);
        PlayerPrefs.SetInt("Rumah",0);
    }

}
