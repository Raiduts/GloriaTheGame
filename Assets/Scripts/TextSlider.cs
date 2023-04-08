using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSlider : MonoBehaviour
{
    [SerializeField] Slider slider; 

    void Start()
    {
        if (!PlayerPrefs.HasKey("MainVolume"))
        {
            PlayerPrefs.SetFloat("MainVolume", Mathf.Log10(slider.value)*20);
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
        slider.value = PlayerPrefs.GetFloat("MainVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("MainVolume", slider.value);
    }
}
