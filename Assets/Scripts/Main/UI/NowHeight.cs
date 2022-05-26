using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NowHeight : MonoBehaviour
{
    Text text;
    private void Start()
    {
        text = GetComponent<Text>();
        if(SecurityPlayerPrefs.GetFloat("Height",-1)==-1)
        {
            SecurityPlayerPrefs.SetFloat("Height",1.2f);
        }
    }
    private void Update()
    {
        if(SecurityPlayerPrefs.GetFloat("Height", -1)<10)
        {
            text.text = "현재 키 : " + SecurityPlayerPrefs.GetFloat("Height", -1)*100 + "cm";
        }
        else
        {
            text.text = "현재 키 : " + SecurityPlayerPrefs.GetFloat("Height", -1) + "m";
        }
    }
}
