using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipButton : MonoBehaviour
{
    public GameObject tip;

    public void tipOn()
    {
        if (tip.activeSelf == false)
        {
            tip.SetActive(true);
        }
    }
}
