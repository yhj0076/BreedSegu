using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kcalCounter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "총 칼로리 : "+SecurityPlayerPrefs.GetInt("kcal",-1)+"kcal";
    }
}
