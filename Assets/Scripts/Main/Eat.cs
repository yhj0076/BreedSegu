using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Eat : MonoBehaviour
{
    public GameObject talkingOn;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Food"&&GameManager.instance.Hold==false)
        {
            //talkButton.SetActive(false);
            //Debug.Log("먹었다");
            switch (collision.name)
            {
                case "FishBread(Clone)":
                    float feelGage = collision.gameObject.GetComponent<FishBread>().FeelControl;
                    GameManager.instance.Feel_UpDown(feelGage);
                    if(feelGage>0)
                    {
                        talkingOn.GetComponent<Animator>().SetBool("GoodFood", true);
                    }
                    else
                    {
                        talkingOn.GetComponent<Animator>().SetBool("GoodFood", false);
                    }
                    break;
                case "Mandoo(Clone)":
                    GameManager.instance.Feel_UpDown(5);
                    talkingOn.GetComponent<Animator>().SetBool("GoodFood",true);
                    break;
                case "OneChip(Clone)":
                    GameManager.instance.Feel_UpDown(-20);
                    WhatThe();
                    talkingOn.GetComponent<Animator>().SetBool("GoodFood", false);
                    break;
                case "Ramen(Clone)":
                    GameManager.instance.Feel_UpDown(10);
                    talkingOn.GetComponent<Animator>().SetBool("GoodFood", true);
                    break;
                case "Worm(Clone)":
                    SecurityPlayerPrefs.SetFloat("Feeling",SecurityPlayerPrefs.GetFloat("Feeling",0)/2);
                    WhatThe();
                    talkingOn.GetComponent<Animator>().SetBool("GoodFood", false);
                    break;
                case "Sushi(Clone)":
                    GameManager.instance.Feel_UpDown(100);
                    talkingOn.GetComponent<Animator>().SetBool("GoodFood", true);
                    break;
            }
            talkingOn.GetComponent<Animator>().SetBool("isEat",true);
            SecurityPlayerPrefs.SetInt("kcal",SecurityPlayerPrefs.GetInt("kcal",0)+SecurityPlayerPrefs.GetInt("Readykcal",0));
            if(SecurityPlayerPrefs.GetFloat("Feeling",-1)>100)
            {
                SecurityPlayerPrefs.SetFloat("Feeling",100);
            }
            else if(SecurityPlayerPrefs.GetFloat("Feeling", -1) < 0)
            {
                SecurityPlayerPrefs.SetFloat("Feeling", 0);
            }
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            SecurityPlayerPrefs.DeleteKey("Readykcal");
        }
    }

    void WhatThe()
    {
        talkingOn.GetComponent<TalkingOn>().eatDisgusting();
    }
}
