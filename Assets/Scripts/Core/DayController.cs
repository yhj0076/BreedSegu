using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DayController : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = "DAY " +SecurityPlayerPrefs.GetInt("DAY",-1);
    }
}
