using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySFX : MonoBehaviour
{
    GameObject soundManager;

    // private void OnMouseUpAsButton()
    // {
    //     if (soundManager.GetComponent<SoundManager>().play)
    //     {
    //         GetComponent<AudioSource>().Play();
    //         soundManager.GetComponent<SoundManager>().play = false;
    //     }
    // }

    private void Awake()
    {
        soundManager = GameObject.Find("SoundManager");
    }

    private void OnMouseUp()
    {
        if (soundManager.GetComponent<SoundManager>().play)
        {
            GetComponent<AudioSource>().Play();
            soundManager.GetComponent<SoundManager>().play = false;
        }
    }
}
