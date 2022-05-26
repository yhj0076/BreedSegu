using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class ExerciseType : MonoBehaviour
{
    public GameObject WhatExerImage;
    public Sprite breath;
    public Sprite run;
    public Sprite jumpRope;
    public Sprite yoga;
    public Sprite none;
    public Text WhatExerText;

    float TallSize = 0;

    int RunGage = 0;

    private void Awake()
    {
        RunGage = 0;
    }

    // Update is called once per frame
    void OnEnable()
    {
        TallSize = (SecurityPlayerPrefs.GetFloat("Exercise", 0) + SecurityPlayerPrefs.GetInt("kcal", 0) / 50) * (SecurityPlayerPrefs.GetFloat("Feeling", 0) / 100);
        switch (SecurityPlayerPrefs.GetFloat("Exercise",-1))
        {
            case 0:
                WhatExerImage.GetComponent<Image>().sprite = breath;
                WhatExerText.text = "운동 종류 : 숨쉬기 운동\n성장한 키 : 0m";
                break;
            case 1:
                WhatExerImage.GetComponent<Image>().sprite = run;
                WhatExerText.text = "운동 종류 : 달리기\n성장한 키 : " + TallSize+"m";
                break;
            case 3:
                WhatExerImage.GetComponent<Image>().sprite = jumpRope;
                WhatExerText.text = "운동 종류 : 트램펄린\n성장한 키 : " + TallSize+"m";
                break;
            case 5:
                WhatExerImage.GetComponent<Image>().sprite = yoga;
                WhatExerText.text = "운동 종류 : 필라테스\n성장한 키 : " + TallSize+"m";
                break;
            default:
                WhatExerImage.GetComponent<Image>().sprite = none;
                WhatExerText.text = "고장났다!!";
                break;
        }
    }

    private void OnDisable()
    {
        if(SecurityPlayerPrefs.GetFloat("Exercise",-1)==0)
        {
            GameManager.instance.Feel_UpDown(10);
            SecurityPlayerPrefs.SetInt("kcal", 0);
        }
        else
        {
            Grow();
        }
        WhatExerImage.GetComponent<Image>().sprite = none;
        GameObject.Find("EatBox").GetComponent<EatBox_Size>().changeScale();
        GameObject.Find("TalkBox").GetComponent<TalkBox_Size>().changeScale();
        RunGage++;
        if (RunGage > 20||SecurityPlayerPrefs.GetInt("Nigerundayo",-1)>=5)
        {
            SecurityPlayerPrefs.SetInt("Nigerundayo", 5);
            SecurityPlayerPrefs.SetInt("EventEnding", 0);
            GameManager.instance.SceneSelect(10);
        }
    }

    private void OnMouseUpAsButton()
    {
        gameObject.SetActive(false);
    }

    void Grow()
    {
        //Debug.Log("키컸다");
        
        SecurityPlayerPrefs.SetFloat("Height", SecurityPlayerPrefs.GetFloat("Height", -1) + TallSize);
        if (SecurityPlayerPrefs.GetFloat("Feeling", 0) > 0)
        {
            GameManager.instance.Feel_UpDown(-10);
            if (SecurityPlayerPrefs.GetFloat("Feeling", 0) <= 5)
            {
                if (SecurityPlayerPrefs.GetInt("Nigerundayo", -99) < 5)
                {
                    SecurityPlayerPrefs.SetInt("Nigerundayo", SecurityPlayerPrefs.GetInt("Nigerundayo", -99) + 1);
                }
            }
        }
        SecurityPlayerPrefs.SetInt("kcal", 0);
        FeelingControl();
    }

    void FeelingControl()
    {
        if (SecurityPlayerPrefs.GetFloat("Feeling", 0) <= 0)
        {
            SecurityPlayerPrefs.SetFloat("Feeling", 0);
        }
    }

    public void disableObj()
    {
        gameObject.SetActive(false);
    }
}
