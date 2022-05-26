using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HowManyEarned : MonoBehaviour
{
    private void LateUpdate()
    {
        GetComponent<Text>().text = "+" + SecurityPlayerPrefs.GetInt("EarnedMoney", -1) + "G";
    }
}
