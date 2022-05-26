using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TalkList : MonoBehaviour
{
    Text talk;
    public GameObject Me;
    public GameObject Fade;
    public GameObject button;
    [SerializeField]
    public string[] talking;

    public int talkIndex;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        talkIndex = 0;
        talk = GetComponent<Text>();
        button.SetActive(true);
    }

    public void Talking()
    {
        talkIndex++;
        if (talkIndex >= talking.Length)
        {
            Fade.GetComponent<FadeControl>().FadeOff();
            Me.GetComponent<MeUp>().Up = false;
            button.SetActive(false);
        }
        else
        {
            talk.text = talking[talkIndex];
        }
    }
}
