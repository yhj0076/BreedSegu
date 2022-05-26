using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingOn : MonoBehaviour
{
    public GameObject TalkingBallon;
    

    public double time = 0;
    public void talkNow()
    {
        TalkingBallon.SetActive(true);
        TalkingBallon.GetComponent<TalkBallon>().Talk();
        time = 0;
        GameObject.Find("GOSEGU").GetComponent<Animator>().SetBool("isTalking", true);
    }

    public void eatDisgusting()
    {
        TalkingBallon.SetActive(true);
        TalkingBallon.GetComponent<TalkBallon>().Eat();
        time = 0;
        //GetComponent<Animator>().SetBool("isEat",true);
    }

    private void OnMouseDown()
    {
        talkNow();
    }

    private void Update()
    {
        if(time>1)
        {
            TalkingBallon.SetActive(false);
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
