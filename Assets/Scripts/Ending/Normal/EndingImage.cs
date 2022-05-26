using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingImage : MonoBehaviour
{
    GameObject staffRoll;
    Image img;
    public Sprite Yes;
    public Sprite No;
    public Sprite Error;
    float time = 0;

    private void Awake()
    {
        time = 0;
        staffRoll = GameObject.Find("스태프롤");
        img = GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (SecurityPlayerPrefs.GetString("isCleared", "e") == "y")
        {
            img.sprite = Yes;
        }
        else if (SecurityPlayerPrefs.GetString("isCleared", "e") == "n")
        {
            img.sprite = No;
        }
        else
        {
            img.sprite = Error;
        }
        img.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(staffRoll.GetComponent<StaffRoll>()==null)
        {
            if(time<Mathf.PI/2)
            {
                time += Time.deltaTime/2;
                img.color = new Color(1, 1, 1, Mathf.Cos(time+Mathf.PI)+1);
            }
            else
            {
                img.color = new Color(1, 1, 1, 1);
            }
        }
    }
}
