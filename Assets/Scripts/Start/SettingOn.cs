using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingOn : MonoBehaviour
{
    public Dropdown display;
    public static SettingOn instance;
    public GameObject Setting;
    /*public AudioMixer masterMixer;
    public Slider audioSlider1;
    public Slider audioSlider2;*/

    bool fullScreen;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("씬에 두 개 이상의 세팅 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if(Screen.fullScreen)
        {
            fullScreen = true;
        }
        else
        {
            fullScreen = false;
        }
        display.value = SecurityPlayerPrefs.GetInt("Display", 0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Setting.activeSelf)
            {
                SetOFF();
            }
            else
            {
                SetON();
            }
        }
    }

    public void forGear()
    {
        if (Setting.activeSelf)
        {
            SetOFF();
        }
        else
        {
            SetON();
        }
    }

    public void SetON()
    {
        Setting.SetActive(true);
        Time.timeScale = 0;
    }

    public void SetOFF()
    {
        Setting.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnDropdownEvent(int index)
    {
        switch (index)
        {
            case 5:
                Screen.SetResolution(640, 360, fullScreen);
                break;                         
            case 4:                            
                Screen.SetResolution(960, 540, fullScreen);
                break;
            case 3:
                Screen.SetResolution(1280, 720, fullScreen);
                break;
            case 2:
                Screen.SetResolution(1600, 900, fullScreen);
                break;
            case 1:
                Screen.SetResolution(1920, 1080, fullScreen);
                break;
            case 0:
                Screen.SetResolution(2560, 1440, fullScreen);
                break;
        }
        SecurityPlayerPrefs.SetInt("Display",index);
    }
}
