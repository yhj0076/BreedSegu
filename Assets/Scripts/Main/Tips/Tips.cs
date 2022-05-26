using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tips : MonoBehaviour
{
    public Sprite[] tips= new Sprite[5];

    int index = 0;
    private void OnEnable()
    {
        index = 0;
        GetComponent<Image>().sprite = tips[0];
    }

    private void OnMouseUpAsButton()
    {
        index++;
        if (index >= tips.Length)
        {
            gameObject.SetActive(false);
        }
        else
        {
            GetComponent<Image>().sprite = tips[index];
        }
    }
}
