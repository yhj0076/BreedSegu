using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class yeyulControl : MonoBehaviour
{
    // public Text title;
    public TextMeshProUGUI title;
    public TextMeshProUGUI subtitle;
    public TextMeshProUGUI whatHappen;
    public Image yeyuls;

    [SerializeField]
    public Sprite[] imageYeyuls;

    public GameObject nogari;
    public GameObject sing;
    // Start is called before the first frame update
    void Start()
    {
        nogari.GetComponent<Button>().enabled = true;
        sing.GetComponent<Button>().enabled = true;
        int choice = Random.Range(0,5);
        switch (choice)
        {
            case 0:
                title.text = "유해균이 너무많아";
                subtitle.text = "오늘따라 악질이 왜 이렇게 많지?";
                whatHappen.text = "기분이 나빠진다.";
                yeyuls.sprite = imageYeyuls[0];
                break;
            case 1:
                title.text = "난 돈이 좋아";
                subtitle.text = "아니!!! 테리아박님!!! 백만원 쿨도네!!!\n간사하빈다!! 아주 나~이스^ㅁ^ㅁ^";
                whatHappen.text = "기분이 좋아진다.";
                yeyuls.sprite = imageYeyuls[1];
                break;
            case 2:
                title.text = "느낌이 좋은데?";
                subtitle.text = "뭐든 잘 될것 같은 기분이 든다.";
                whatHappen.text = "똥겜벵에서 돈 버는 속도가 늘어난다.";
                yeyuls.sprite = imageYeyuls[2];
                break;
            case 3:
                title.text = "목이 안좋아";
                subtitle.text = "콜록콜록...\n세구세구땅...넘 아파...ㅠㅠㅠ";
                whatHappen.text = "노가리와 노래방 컨텐츠를 할 수 없다.";
                nogari.GetComponent<Button>().enabled = false;
                sing.GetComponent<Button>().enabled = false;
                yeyuls.sprite = imageYeyuls[3];
                break;
            case 4:
                title.text = "고랄";
                subtitle.text = "오늘따라 와타시가 초카와이한 느낌인걸??\n뀨우★";
                whatHappen.text = "노가리에서 큰 돈을 벌지도...?";
                yeyuls.sprite = imageYeyuls[4];
                SecurityPlayerPrefs.SetInt("GetBoost", 1);
                break;
            default:
                title.text = "오류";
                subtitle.text = "error";
                whatHappen.text = "망했다 ㅅㄱ 고장남";
                break;
        }
        SecurityPlayerPrefs.SetInt("yeyul",choice);
    }
}
