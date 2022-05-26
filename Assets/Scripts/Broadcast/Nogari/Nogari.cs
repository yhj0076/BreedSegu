using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Nogari : MonoBehaviour
{
    public int hurt = 0;
    int times = 30;

    float time = 0;
    float time2 = 0;

    public bool GetBoost;       //예열 이벤트(수입 상승)

    public GameObject gobaButton;
    public GameObject gobaText;
    public GameObject chatGen;
    // Start is called before the first frame update
    void Start()
    {
        hurt = 0;
        SecurityPlayerPrefs.SetInt("EarnedMoney",500);
        times = 30;
        GetComponent<Text>().text = times + "s";
    }

    private void Update()
    {
        if(hurt>4)
        {
            SecurityPlayerPrefs.SetInt("EventEnding", 1);
            GameManager.instance.SceneSelect(10);
        }

        time += Time.deltaTime;
        if (time>1&&times>0)
        {
            times -= 1;
            GetComponent<Text>().text = times + "s";
            time -= 1;
        }
        else if(times <= 0)
        {
            GetComponent<Text>().text = times + "s";
            gobaButton.SetActive(true);
            gobaText.SetActive(true);
            chatGen.SetActive(false);
            GetBoost = false;
        }

        if (GetBoost)
        {
            if (time2 > 0.2f && times > 0 && SecurityPlayerPrefs.GetInt("EarnedMoney", -1) > 0)
            {
                SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -1) - 1);
                time2 -= 0.2f;
            }
            else
            {
                time2 += Time.deltaTime;
            }
        }
        else
        {
            if (time2 > 0.05f && times > 0 && SecurityPlayerPrefs.GetInt("EarnedMoney", -1) > 0)
            {
                SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -1) - 1);
                time2 -= 0.05f;
            }
            else
            {
                time2 += Time.deltaTime;
            }
        }
    }
}
