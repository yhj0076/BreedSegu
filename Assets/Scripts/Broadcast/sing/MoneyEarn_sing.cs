using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyEarn_sing : MonoBehaviour
{
    float time = 0;
    public GameObject gsg;
    private void Start()
    {
        time = 0;
        SecurityPlayerPrefs.SetInt("EarnedMoney", 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (gsg != null)
        {
            time += Time.deltaTime;
            if (time > 0.3f)
            {
                SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -1) + 1);
                GetComponent<Text>().text = "+" + SecurityPlayerPrefs.GetInt("EarnedMoney", -1) + "G";
                time = time-0.3f;
            }
        }
    }
}
