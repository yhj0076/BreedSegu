using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class TapArrow : MonoBehaviour
{
    public GameObject Sucsess1;
    public GameObject Sucsess2;
    public GameObject Sucsess3;
    public GameObject Sucsess4;

    public GameObject Notes;
    public GameObject DMG;
    public GameObject Life;
    public GameObject dance;
    public bool isOK;


    private void Awake()
    {
        SecurityPlayerPrefs.SetInt("EarnedMoney", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Notes.transform.childCount > 0)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && Notes.transform.GetChild(0).name == "리듬겜 노트 Up(Clone)")
            {
                Earn(2);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && Notes.transform.GetChild(0).name == "리듬겜 노트 Down(Clone)")
            {
                Earn(3);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && Notes.transform.GetChild(0).name == "리듬겜 노트 Left(Clone)")
            {
                Earn(1);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && Notes.transform.GetChild(0).name == "리듬겜 노트 Right(Clone)")
            {
                Earn(4);
            }
            // else if (Input.GetKeyDown(KeyCode.UpArrow) && Notes.transform.GetChild(0).name != "리듬겜 노트 Up(Clone)" ||
            //         Input.GetKeyDown(KeyCode.DownArrow) && Notes.transform.GetChild(0).name != "리듬겜 노트 Down(Clone)" ||
            //         Input.GetKeyDown(KeyCode.LeftArrow) && Notes.transform.GetChild(0).name != "리듬겜 노트 Left(Clone)" ||
            //         Input.GetKeyDown(KeyCode.RightArrow) && Notes.transform.GetChild(0).name != "리듬겜 노트 Right(Clone)")
            // {
            //     Life.GetComponent<Life>().Damage();
            // }
        }
    }

    void Earn(int index)
    {
        if (isOK)
        {
            GetComponent<AudioSource>().Play();
            SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -1) + 2);
            switch (index)
            {
                case 1:
                    Sucsess1.GetComponent<Check_Sucsess>().ok = true;
                    Sucsess1.GetComponent<Check_Sucsess>().dirIndex = 0;
                    break;
                case 2:
                    Sucsess2.GetComponent<Check_Sucsess>().ok = true;
                    Sucsess2.GetComponent<Check_Sucsess>().dirIndex = 1;
                    break;
                case 3:
                    Sucsess3.GetComponent<Check_Sucsess>().ok = true;
                    Sucsess3.GetComponent<Check_Sucsess>().dirIndex = 2;
                    break;
                case 4:
                    Sucsess4.GetComponent<Check_Sucsess>().ok = true;
                    Sucsess4.GetComponent<Check_Sucsess>().dirIndex = 3;
                    break;
            }
            Debug.Log(Time.time);
        }
        dance.GetComponent<DanceAnimation>().changeImage();
        Destroy(Notes.transform.GetChild(0).gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isOK = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "note")
        {
            isOK = false;
            collision.transform.parent = DMG.transform;
        }
    }
}
