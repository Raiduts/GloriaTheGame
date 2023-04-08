using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSlider : MonoBehaviour
{
    [SerializeField] Slider slider; 

    void Start()
    {
        if (!PlayerPrefs.HasKey("mainVolume"))
        {
            PlayerPrefs.SetFloat("mainVolume", 100);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = slider.value;
        Save();
    }
    private void Load()
    {
        slider.value = PlayerPrefs.GetFloat("mainVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("mainVolume", slider.value);
    }
}
