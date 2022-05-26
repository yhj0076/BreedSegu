using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class WhenBangOn : MonoBehaviour
{
    public GameObject yeyulWindow;
    public bool isOn = false;
    private void Start()
    {
        isOn = false;
    }
    public void childObjOn()
    {
        if(isOn)
        {
            yeyulWindow.SetActive(false);
            isOn = false;
        }
        else
        {
            yeyulWindow.SetActive(true);
            isOn = true;
        }
        GetComponent<AudioSource>().Play();
    }
}
