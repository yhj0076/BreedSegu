using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeController : MonoBehaviour
{
    public float time = 0;

    int Hour = 7;
    int Minute = 0;

    string hour;
    string minute;

    private void Start()
    {
        time = 0;
        Hour = 7;
        Minute = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>0.1f&&Hour<24)
        {
            Minute++;
            TimeCalc();
            MinuteCalc();
            HourCalc();
            GetComponent<Text>().text = hour+" : "+minute;
            time = 0;
        }
    }
    
    void TimeCalc()
    {
        if(Minute>=60)
        {
            Hour++;
            Minute = 0;
        }
    }

    void MinuteCalc()
    {
        if(Minute<10)
        {
            minute = "0" + Minute;
        }
        else
        {
            minute = ""+Minute;
        }
    }

    void HourCalc()
    {
        if(Hour<10)
        {
            hour = "0" + Hour;
        }
        else
        {
            hour = "" + Hour;
        }
    }
}
