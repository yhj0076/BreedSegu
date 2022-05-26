using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool Hold;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Time.timeScale = 1;
            Cursor.visible = true;
        }
        else
        {
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (SecurityPlayerPrefs.GetInt("Money", -1) == -1)
        {
            SecurityPlayerPrefs.SetInt("Money", 500);
        }
    }

    public void Feel_UpDown(float feeling)
    {
        SecurityPlayerPrefs.SetFloat("Feeling", SecurityPlayerPrefs.GetFloat("Feeling", 0) + feeling);
    }

    public void SceneSelect(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void JustGoBa()
    {
        SecurityPlayerPrefs.SetFloat("Feeling", SecurityPlayerPrefs.GetFloat("Feeling", 0) + 5);
        SceneManager.LoadScene(3);
        SecurityPlayerPrefs.SetInt("EarnedMoney",0);
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
