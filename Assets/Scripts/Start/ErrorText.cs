using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ErrorText : MonoBehaviour
{
    public float time = 0;
    Text error;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if(time<Mathf.PI/2)
        {
            error.color = new Color(0, 0, 0, Mathf.Cos(time));
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        error = GetComponent<Text>();
        time = 0;
    }
}
