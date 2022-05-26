using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youarehere : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.SetActive(false);
        }
    }
}
