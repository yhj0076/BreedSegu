using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(SecurityPlayerPrefs.GetInt("Money",0)<0)
        {
            SecurityPlayerPrefs.SetInt("Money",0);
        }
        GetComponent<Text>().text = "돈 : " + SecurityPlayerPrefs.GetInt("Money", -1) + "G";
    }
}
