using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartManager : MonoBehaviour
{
    public int StartMoney;
    public GameObject ErrorText;

    private void Awake()
    {
        if(SecurityPlayerPrefs.GetFloat("volumeControl_BGM", -1) == -1)
        {
            SecurityPlayerPrefs.SetFloat("volumeControl_BGM", -12);
        }
        if (SecurityPlayerPrefs.GetFloat("volumeControl_SFX", -1) == -1)
        {
            SecurityPlayerPrefs.SetFloat("volumeControl_SFX", -12);
        }
    }

    public void FirstStart()
    {
        SecurityPlayerPrefs.SetFloat("Feeling",100);
        SecurityPlayerPrefs.SetFloat("Height", 1.2f);
        SecurityPlayerPrefs.SetInt("DAY", 1);
        SecurityPlayerPrefs.SetInt("Money",StartMoney);
        SecurityPlayerPrefs.SetInt("kcal",0);
        SecurityPlayerPrefs.SetString("isCleared", "n");
        SecurityPlayerPrefs.SetInt("Nigerundayo", 0);
        SecurityPlayerPrefs.DeleteKey("Readykcal");
        SceneManager.LoadScene(1);
    }
    public void ReStart()
    {
        if (SecurityPlayerPrefs.GetFloat("DAY", 0) <= 0)
        {
            ErrorText.SetActive(true);
            ErrorText.GetComponent<ErrorText>().time = 0;
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.G))
        {
            SecurityPlayerPrefs.DeleteAll();
        }
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit(); // 어플리케이션 종료
#endif
    }
}
