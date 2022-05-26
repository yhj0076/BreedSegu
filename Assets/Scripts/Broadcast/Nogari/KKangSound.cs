using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class KKangSound : MonoBehaviour
{
    public bool hit = false;

    private void Awake()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            GetComponent<AudioSource>().Play();
            hit = false;
        }
    }
}
