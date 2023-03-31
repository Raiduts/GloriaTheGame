using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowHealth : MonoBehaviour
{ 
    public static ShowHealth instance;
    public TextMeshProUGUI healthText;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        healthText.text = Data.health.ToString();
    }

}
