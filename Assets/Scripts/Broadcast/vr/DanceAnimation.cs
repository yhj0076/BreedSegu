using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DanceAnimation : MonoBehaviour
{
    public Sprite[] images = new Sprite[4];

    int beforeIndex = -1;
    int Index = -1;
    public double bpm = 0;
    double time = 0;


    private void Start()
    {
        beforeIndex = -1;
        Index = -1;

        Invoke("delayGetBPM",3.36f);
    }

    void delayGetBPM()
    {
        bpm = FindObjectOfType<RythmMaker_Test>().BPM;
    }

    private void Update()
    {
        dance();
    }

    public void changeImage()
    {
        do
        {
            Index = Random.Range(0, 4);
        } while (Index == beforeIndex);

        GetComponent<Image>().sprite = images[Index];
        beforeIndex = Index;
    }

    void dance()
    {
        time += Time.deltaTime;
        if (time >= 60d / bpm)
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(821, 821);
            time -= 60d / bpm;
        }
        else
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(821f, 821-(30*(float)time*(float)bpm/60f));
        }
    }
}
