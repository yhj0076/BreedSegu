using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffWindow : MonoBehaviour
{
    public GameObject obsOn;
    public void close()
    {
        obsOn.GetComponent<WhenBangOn>().isOn = false;
        transform.parent.gameObject.SetActive(false);
    }
}
