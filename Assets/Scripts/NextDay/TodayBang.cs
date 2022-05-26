using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TodayBang : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string bangsong = "몰?루";
        switch (SecurityPlayerPrefs.GetInt("Broadcast",-1))
        {
            case 4:
                bangsong = "노가리";
                break;
            case 5:
                bangsong = "브알챗";
                break;
            case 6:
                bangsong = "노래뱅";
                break;
            case 7:
                bangsong = "똥겜";
                break;
            default:
                bangsong = "없음";
                break;
        }
        GetComponent<Text>().text = "오뱅내 : " + bangsong;
    }
}
