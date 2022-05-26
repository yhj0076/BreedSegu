using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkBallon : MonoBehaviour
{
    [SerializeField]
    public string[] seguTalk;
    public GameObject Talkballon;
    public Text talking;

    int dontTouch = 0;

    int beforeTalkIndex = -1;
    int index = 0;

    private void OnDisable()
    {
        beforeTalkIndex = -1;
    }
    public void Talk()
    {
        //Debug.Log("말했다");
        do
        {
            index = Random.Range(0, seguTalk.Length);
        } while (beforeTalkIndex == index);
        beforeTalkIndex = index;
        if(dontTouch<6)
        {
            talking.GetComponent<Text>().text = seguTalk[index];
            dontTouch++;
        }
        else
        {
            SecurityPlayerPrefs.SetFloat("Feeling", SecurityPlayerPrefs.GetFloat("Feeling", 0) - 5);
            talking.GetComponent<Text>().text = "그믄 근드스여\n(그만 건드세여)";
        }
    }
    public void Eat()
    {
        talking.GetComponent<Text>().text = "구웨엑;;";
    }
}
