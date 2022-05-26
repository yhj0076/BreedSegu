using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyEarn_shit : MonoBehaviour
{
    Text G;
    float time = 0;
    public GameObject GSG;
    public GameObject YouAreHere;
    public bool GetBoost;
    float waitTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        G = GetComponent<Text>();
        SecurityPlayerPrefs.SetInt("EarnedMoney", 0);
        G.text = "+" + SecurityPlayerPrefs.GetInt("EarnedMoney", -1) + "G";
        if (GetBoost)
        {
            waitTime = 0.1f;
        }
        else
        {
            waitTime = 0.5f;
        }
        YouAreHere.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (GSG.GetComponent<seguMoving>().hit == false)
        {
            time += Time.deltaTime;
            if (time > waitTime)
            {
                SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -1) + 1);
                G.text = "+" + SecurityPlayerPrefs.GetInt("EarnedMoney", -1) + "G";
                time = 0;
            }
        }
    }
}
