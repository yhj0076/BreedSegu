using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LastTallGap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float tall = SecurityPlayerPrefs.GetFloat("Height",-1)-SecurityPlayerPrefs.GetFloat("LastHeight",-1);
        if (tall < 10)
        {
            GetComponent<Text>().text = "오늘 큰 키 : " + tall * 100 + "cm";
        }
        else
        {
            GetComponent<Text>().text = "오늘 큰 키 : " + tall + "m";
        }
    }

    
}
