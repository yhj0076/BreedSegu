using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleSpin : MonoBehaviour
{
    void Start()
    {
        Invoke("delayObjtrue",1f);
        Invoke("delayObjtrue1",1.5f);
        Invoke("delayObjtrue2",1.8f);
    }

    // Update is called once per frame
    /*void Update()
    {
        time += Time.deltaTime;
        transform.rotation = Quaternion.Euler(0,0,time*speed);
    }*/

    void delayObjtrue()
    {
        transform.GetChild(1).gameObject.SetActive(true);
    }
    void delayObjtrue1()
    {
        transform.GetChild(2).gameObject.SetActive(true);
    }
    void delayObjtrue2()
    {
        transform.GetChild(3).gameObject.SetActive(true);
    }
}
