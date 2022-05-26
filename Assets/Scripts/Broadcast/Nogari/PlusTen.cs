using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlusTen : MonoBehaviour
{
    float time = 0;
    public GameObject kkang;
    // Start is called before the first frame update
    void Start()
    {
        time = Mathf.PI/2;
    }

    // Update is called once per frame
    void Update()
    {
        if (time < Mathf.PI / 2)
        {
            time += Time.deltaTime*3f;
        }
        else
        {
            time = Mathf.PI / 2;
        }
        if(kkang.GetComponent<KKangSound>().hit)
        {
            time = 0;
        }
        GetComponent<Text>().color = new Color(0.196f,0.196f,0.196f,Mathf.Cos(time));
    }
}
