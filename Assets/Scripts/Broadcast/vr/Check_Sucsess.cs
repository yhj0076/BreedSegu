using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check_Sucsess : MonoBehaviour
{
    float time = 0;

    public bool ok;
    public int arrowDir;

    public int dirIndex;    //좌상하우1234
    private void OnEnable()
    {
        time = 0;
    }

    private void Update()
    {
        time -= Time.deltaTime*2;
        if(ok && dirIndex==arrowDir)
        {
            time = 1;
            ok = false;
        }
        GetComponent<Text>().color = new Color(1, 1, 1, time);
    }
}
