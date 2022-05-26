using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ComposerAndSong : MonoBehaviour
{
    float time = Mathf.PI/2;
    // Start is called before the first frame update
    void Start()
    {
        switch(FindObjectOfType<StartMusicDelay>().MusicIndex)
        {
            case 0:
                GetComponent<Text>().text = "dior816 - 개같이 부활";
                break;
            case 1:
                GetComponent<Text>().text = "추르르 - 인생의 무7목마";
                break;
            case 2:
                GetComponent<Text>().text = "윤수저 - 미쳤잖아";
                break;
            default:
                GetComponent<Text>().text = "오류 - ERROR";
                break;
        }
    }

    private void Update()
    {
        time -= Time.deltaTime;
        GetComponent<Text>().color = new Color(1, 1, 1, Mathf.Sin(time));
        if(time<=0)
        {
            gameObject.SetActive(false);
        }
    }
}
