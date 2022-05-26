using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoseguFeelingControl : MonoBehaviour
{
    public Sprite Good;
    public Sprite Bad;
    // Update is called once per frame
    void LateUpdate()
    {
        if (SecurityPlayerPrefs.GetFloat("Feeling", -1) < 50)
            GetComponent<Image>().sprite = Bad;
        else
            GetComponent<Image>().sprite = Good;
    }
}
