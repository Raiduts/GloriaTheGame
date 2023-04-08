using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleUrutan : MonoBehaviour
{
    public GameObject teleporter1;
    public GameObject teleporter2;
    public GameObject teleporter3;

    public void Update(){
        switch (SaveData.progress)
        {
            case 0:
                teleporter1.SetActive(true);
                teleporter2.SetActive(false);
                teleporter3.SetActive(false);
                break;
            case 1:
                teleporter1.SetActive(false);
                teleporter2.SetActive(true);
                teleporter3.SetActive(false);
                break;
            case 2:
                teleporter1.SetActive(false);
                teleporter2.SetActive(false);
                teleporter3.SetActive(true);
                break;
            default:
                break;
        }
    }
}
