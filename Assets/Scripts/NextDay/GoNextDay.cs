using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoNextDay : MonoBehaviour
{
    public void NextDay()
    {
        if (SecurityPlayerPrefs.GetInt("Nigerundayo",-1)<5)
        {
            if (SecurityPlayerPrefs.GetInt("DAY", -1) < 30)
            {
                SecurityPlayerPrefs.SetInt("DAY", SecurityPlayerPrefs.GetInt("DAY", -99) + 1);
                if (SecurityPlayerPrefs.GetFloat("Feeling", -1) >= 50)
                {
                    SecurityPlayerPrefs.SetInt("Nigerundayo", SecurityPlayerPrefs.GetInt("Nigerundayo", -99) - 1);
                }
                GameManager.instance.SceneSelect(2);
            }
            else if(SecurityPlayerPrefs.GetInt("DAY", -1) == 30)
            {
                if (SecurityPlayerPrefs.GetFloat("Height", -1) >= 300)
                {
                    SecurityPlayerPrefs.SetString("isCleared", "y");
                }
                GameManager.instance.SceneSelect(8);
            }
        }
        else
        {
            SecurityPlayerPrefs.SetInt("EventEnding",0);
            GameManager.instance.SceneSelect(10);
        }
        SecurityPlayerPrefs.SetInt("Money", SecurityPlayerPrefs.GetInt("Money", -9999) + SecurityPlayerPrefs.GetInt("EarnedMoney", -1));

        if(SecurityPlayerPrefs.GetFloat("Feeling", -1)<5)
        {
            SecurityPlayerPrefs.SetInt("Nigerundayo", SecurityPlayerPrefs.GetInt("Nigerundayo", -99)+1);
        }
    }
}
