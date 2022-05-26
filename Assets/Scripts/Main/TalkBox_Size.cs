using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBox_Size : MonoBehaviour
{
    public void changeScale()
    {
        transform.localScale = new Vector3(1, SecurityPlayerPrefs.GetFloat("Height", -1) / 60 + 1, 1);
    }
}
