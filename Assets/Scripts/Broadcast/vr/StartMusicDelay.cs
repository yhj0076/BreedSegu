using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class StartMusicDelay : MonoBehaviour
{
    public GameObject goba;

    [SerializeField]
    public AudioClip[] music;
    public int MusicIndex;

    bool go;
    // Start is called before the first frame update
    void Awake()
    {
        go = false;
        MusicIndex = Random.Range(0,3);
        //MusicIndex = 0;
        GetComponent<AudioSource>().clip = music[MusicIndex];
        /*switch(MusicIndex)
        {
            case 0:     //개같이 부활 - 3.2
                GetComponent<AudioSource>().PlayDelayed(2.77f);
                break;
            case 2:     //미쳣잖아 - 3.04
                GetComponent<AudioSource>().PlayDelayed(2.77f);
                break;
            default:    //무7목마 - 3.1
                GetComponent<AudioSource>().PlayDelayed(2.77f);
                break;
        }*/
        GetComponent<AudioSource>().PlayDelayed(2.775f);
    }

    public void delayGo()
    {
        Invoke("Go", 5f);
    }

    void Go()
    {
        go = true;
    }

    private void Update()
    {
        if(go)
        {
            goba.SetActive(true);
        }
    }
}
