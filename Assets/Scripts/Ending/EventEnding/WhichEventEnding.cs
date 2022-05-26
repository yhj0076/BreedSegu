using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class WhichEventEnding : MonoBehaviour
{
    public AudioClip nigero;
    public AudioClip revolution;
    AudioSource soundPlayer;

    public GameObject NIGERO;
    public GameObject REVOLUTION;

    private void Awake()
    {
        soundPlayer = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        switch (SecurityPlayerPrefs.GetInt("EventEnding",-1))
        {
            //탈주 엔딩
            case 0:
                NIGERO.SetActive(true);
                soundPlayer.clip = nigero;
                break;
            //혁명 엔딩
            case 1:
                REVOLUTION.SetActive(true);
                soundPlayer.clip = revolution;
                break;
        }
        soundPlayer.Play();
    }
}
