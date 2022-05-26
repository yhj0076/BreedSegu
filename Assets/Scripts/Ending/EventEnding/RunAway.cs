using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{
    public void restart()
    {
        SecurityPlayerPrefs.SetFloat("Feeling", 10);
        SecurityPlayerPrefs.SetInt("Nigerundayo", 4);
        GameManager.instance.SceneSelect(2);
    }

    public void giveUp()
    {
        SecurityPlayerPrefs.DeleteAll();
        SecurityPlayerPrefs.SetFloat("Feeling", 100);
        SecurityPlayerPrefs.SetFloat("Height", 1.2f);
        SecurityPlayerPrefs.SetInt("DAY", 1);
        SecurityPlayerPrefs.SetInt("Money", 500);
        SecurityPlayerPrefs.SetInt("kcal", 0);
        SecurityPlayerPrefs.SetString("isCleared", "n");
        SecurityPlayerPrefs.SetInt("Nigerundayo", 0);
        SecurityPlayerPrefs.SetFloat("volumeControl_BGM", -12);
        SecurityPlayerPrefs.SetFloat("volumeControl_SFX", -12);

        GameManager.instance.SceneSelect(0);
    }
}
