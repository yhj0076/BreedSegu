using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HowMuchEarned : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "총 수익 : " + SecurityPlayerPrefs.GetInt("EarnedMoney",-1)+"G";
    }

}
