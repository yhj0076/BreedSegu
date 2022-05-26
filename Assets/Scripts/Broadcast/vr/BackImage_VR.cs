using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackImage_VR : MonoBehaviour
{
    public Sprite[] background = new Sprite[3];
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = background[FindObjectOfType<StartMusicDelay>().MusicIndex];
    }
}
