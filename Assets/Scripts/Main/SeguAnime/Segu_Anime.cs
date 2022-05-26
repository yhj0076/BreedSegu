using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Segu_Anime : MonoBehaviour
{
    public GameObject TalkBallon;
    public GameObject EatBox;
    Animator anime;

    private void Awake()
    {
        anime = GetComponent<Animator>();
        FeelingAnime();
    }

    // Update is called once per frame
    void Update()
    {
        FeelingAnime();
        if(EatBox.GetComponent<AudioSource>().isPlaying==false)
        {
            anime.SetBool("isEat",false);
        }
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("Segu_Good_Talking") || anime.GetCurrentAnimatorStateInfo(0).IsName("Segu_Bad_Talking"))
        {
            anime.SetBool("isTalking", false);
        }
    }

    void TalkingAnime()
    {
        if (TalkBallon.activeSelf == true)
        {
            anime.SetBool("isTalking", true);
        }
        else
        {
            anime.SetBool("isTalking", false);
        }
    }

    void FeelingAnime()
    {
        if (SecurityPlayerPrefs.GetFloat("Feeling", 0) <= 50)
        {
            anime.SetBool("isBad", true);
        }
        else
        {
            anime.SetBool("isBad", false);
        }
    }
}
