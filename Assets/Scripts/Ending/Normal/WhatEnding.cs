using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WhatEnding : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        if (SecurityPlayerPrefs.GetString("isCleared", "e") == "y")
        {
            GetComponent<TextMeshProUGUI>().text = "HAPPY ENDING";
        }
        else if (SecurityPlayerPrefs.GetString("isCleared", "e") == "n")
        {
            GetComponent<TextMeshProUGUI>().text = "BAD ENDING";
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "WTF ENDING";
        }
    }
}
