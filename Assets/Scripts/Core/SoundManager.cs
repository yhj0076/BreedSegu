using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class SoundManager : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider1;
    public Slider audioSlider2;
    public bool play;

    private void Start()
    {
        play = false;
        if (SecurityPlayerPrefs.GetFloat("volumeControl_BGM", -1) == -1)
        {
            SecurityPlayerPrefs.SetFloat("volumeControl_BGM", audioSlider1.value);
        }
        else
        {
            if (audioSlider1 != null)
            {
                audioSlider1.value = SecurityPlayerPrefs.GetFloat("volumeControl_BGM", -1);
            }
        }

        if (SecurityPlayerPrefs.GetFloat("volumeControl_SFX", -1) == -1)
        {
            SecurityPlayerPrefs.SetFloat("volumeControl_SFX", audioSlider2.value);
        }
        else
        {
            if (audioSlider2 != null)
            {
                audioSlider2.value = SecurityPlayerPrefs.GetFloat("volumeControl_SFX", -1);
            }
        }
    }

    public void AudioControlBGM()
    {
        SecurityPlayerPrefs.SetFloat("volumeControl_BGM", audioSlider1.value);
        if (SecurityPlayerPrefs.GetFloat("volumeControl_BGM", 0) == -40f)
        {
            masterMixer.SetFloat("BGM", -80);
        }
        else
        {
            masterMixer.SetFloat("BGM", SecurityPlayerPrefs.GetFloat("volumeControl_BGM", 0));
        }
    }

    public void AudioControlSFX()
    {
        SecurityPlayerPrefs.SetFloat("volumeControl_SFX", audioSlider2.value);
        if (SecurityPlayerPrefs.GetFloat("volumeControl_SFX", 0) == -40f)
        {
            masterMixer.SetFloat("SFX", -80);
        }
        else
        {
            masterMixer.SetFloat("SFX", SecurityPlayerPrefs.GetFloat("volumeControl_SFX", 0));
        }
        play = true;
    }
}
