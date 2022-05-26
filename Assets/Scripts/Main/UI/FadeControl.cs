using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour
{
    Image image;
    bool fade;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        time = 0;
        fade = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(fade==false&&time<Mathf.PI/2)
        {
            time += Time.deltaTime;
            image.color = new Color(0,0,0,Mathf.Cos(time));
        }
        else if(fade&&time<Mathf.PI/2)
        {
            time += Time.deltaTime;
            image.color = new Color(0,0,0,Mathf.Cos(time+Mathf.PI)+1);
        }
    }

    public void FadeOn()
    {
        fade = false;
        time = 0;
    }

    public void FadeOff()
    {
        fade = true;
        time = 0;
    }
}
