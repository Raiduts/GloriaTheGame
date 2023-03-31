using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public int maxHealth;
    public static int health;
    static int material;

    void Start()
    {
        health = maxHealth;
    }

}
