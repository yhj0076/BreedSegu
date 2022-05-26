using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTiming : MonoBehaviour
{
    public GameObject generator;
    void OnEnable()
    {
        //Invoke("delayStart",0.42f);
    }

    void delayStart()
    {
        generator.SetActive(true);
    }
}
