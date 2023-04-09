using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRumah : MonoBehaviour
{

    public GameObject rumah1;
    public GameObject template1;
    public GameObject rumah2;
    public GameObject template2;

    void Update()
    {
        if (SaveData.rumah >= 1)
        {
            rumah1.SetActive(true);
            template1.SetActive(false);
        }
        if (SaveData.rumah >= 2)
        {
            rumah2.SetActive(true);
            template2.SetActive(false);
        }
    }
}
