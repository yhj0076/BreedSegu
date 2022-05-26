using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOSEGU_Size : MonoBehaviour
{
    RectTransform rect;
    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }
    // Update is called once per frame
    void Update()
    {
        rect.localScale = new Vector3(1, SecurityPlayerPrefs.GetFloat("Height",-1)/60+1, 1);
    }
}
