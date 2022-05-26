using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FeelingGage : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().fillAmount = SecurityPlayerPrefs.GetFloat("Feeling", 0)/100;
    }
}
