using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBroadcast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject moneyEarn = GameObject.Find("EarnedMoney");
        GameObject nogari = GameObject.Find("PlusMoney");
        switch (SecurityPlayerPrefs.GetInt("yeyul",-1))
        {
            case 0:
                GameManager.instance.Feel_UpDown(-20);
                break;
            case 1:
                GameManager.instance.Feel_UpDown(20);
                break;
            case 2:
                if(moneyEarn!=null)
                    moneyEarn.GetComponent<MoneyEarn_shit>().GetBoost = true;
                break;
            case 3:
                break;
            case 4:
                if (nogari != null)
                    nogari.GetComponent<Nogari>().GetBoost = true;
                break;
        }
    }

}
