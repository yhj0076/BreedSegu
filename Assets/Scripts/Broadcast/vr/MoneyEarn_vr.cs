using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyEarn_vr : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "+"+SecurityPlayerPrefs.GetInt("EarnedMoney", -1)+"G";
    }
}
