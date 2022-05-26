using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingMent : MonoBehaviour
{
    string[] EndMent_Y = new string[10];
    string[] EndMent_N = new string[5];
    public GameObject Fade;
    string[] endingMent;
    int index = 0;

    public Text talking;
    // Start is called before the first frame update

    

    private void Awake()
    {
        EndMent_N[0] = "자네 잘 지냈나!\n내가 돌아왔다네!";
        EndMent_N[1] = "세구세구땅은 좀 어떤가..?";
        EndMent_N[2] = "음...\n" + SecurityPlayerPrefs.GetFloat("Height",-1)+"m인가...";
        EndMent_N[3] = "생각보다 좀 더디게 자라는구만..";
        EndMent_N[4] = "안되겠어!! 자네는 남아서\n나와 좀 더 연구를 하자고!!";

        EndMent_Y[0] = "자네 잘 지냈나!\n내가 돌아왔다네!";
        EndMent_Y[1] = "아 멀리서 이미 봤네!\n멋지게 연구실 천장을 부셨더군!";
        EndMent_Y[2] = "그래서 정확히 키가 얼마인거지?";
        EndMent_Y[3] = "이, 이럴수가!\n" + SecurityPlayerPrefs.GetFloat("Height", -1) + "m라니!!";
        EndMent_Y[4] = "이거라면 학회에서도 인정 받을 수 있을꺼야!!";
        EndMent_Y[5] = "[뚜루루...뚜루루..]";
        EndMent_Y[6] = "[찰칵]";
        EndMent_Y[7] = "어! 햄이네 박사! 날세!";
        EndMent_Y[8] = "내가 방금 폭풍성장의 열쇠를 손에 넣었어!!";
        EndMent_Y[9] = "아, 자네는 이제 가보게! 수고했네!!";
    }

    void Start()
    {
        index = 0;
        if(SecurityPlayerPrefs.GetString("isCleared","e")=="y")
        {
            endingMent = new string[EndMent_Y.Length];
            for (int i = 0; i<EndMent_Y.Length;i++)
            {
                endingMent[i] = EndMent_Y[i];
            }
        }
        else if(SecurityPlayerPrefs.GetString("isCleared","e")=="n")
        {
            endingMent = new string[EndMent_N.Length];
            for (int i = 0; i < EndMent_N.Length; i++)
            {
                endingMent[i] = EndMent_N[i];
            }
        }
        talking.text = endingMent[0];
    }

    private void OnMouseUp()
    {
        if (index < endingMent.Length)
        {
            index++;
            if (index < endingMent.Length)
            {
                talking.text = endingMent[index];
            }
            else
            {
                Fade.GetComponent<FadeControl>().FadeOff();
                StartCoroutine("NextScene");
            }
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Mouse0) && index < endingMent.Length)
    //     {
    //         index++;
    //         if(index<endingMent.Length)
    //         {
    //             talking.text = endingMent[0];
    //         }
    //         else
    //         {
    //             Fade.GetComponent<FadeControl>().FadeOff();
    //             StartCoroutine("NextScene");
    //         }
    //     }
    // }

    

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(Mathf.PI / 2);
        GameManager.instance.SceneSelect(9);
        StopCoroutine("NextScene");
    }
}
