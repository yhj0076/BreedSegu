using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ErrorFood : MonoBehaviour
{
    Text message;
    public float time = 0;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        message.color = new Color(0,0,0,Mathf.Cos(time));
        if(time>Mathf.PI/2)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        time = 0;
        message = GetComponent<Text>();
    }
}
