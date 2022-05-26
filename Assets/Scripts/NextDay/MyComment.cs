using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyComment : MonoBehaviour
{
    int choice = 0;
    string[] comments = new string[20];
    // Start is called before the first frame update
    void Awake()
    {
        comments[0] = "세구세구땅은 세구님과 99% 일치한다고 합니다.\n대단하군요 고파민박사!";
        comments[1] = "밀웜은 가장 칼로리가 높은 음식입니다.\n하지만 세구세구땅은 굉장히 싫어하죠.";
        comments[2] = "붕어빵은 슈붕입니다. ㅇㅈ?";
        comments[3] = "붕어빵을 먹였는데 기분이 나빠졌다면\n그건 팥붕이었을겁니다. 저런!";
        comments[4] = "어...있잖아요....\nㅟㅟㅟㅟㅟ 말 안할래요";
        comments[5] = "ESC를 통해 설정창을 열 수 있습니다.";
        comments[6] = "고\n갈\n통";
        comments[7] = "여기 나오는 모든 음식은 세구세구땅용입니다.\n일반적인 사람은 먹을 수 없습니다.";
        comments[8] = "세구세구땅이 제일 좋아하는 음식은 슈붕이라고 합니다.";
        comments[9] = "세구세구땅이 제일 싫어하는 음식은 밀웜이라고 합니다.";
        comments[10] = "낮은 확률로 연어초밥이 나옵니다.\n차원이 다른 성능을 자랑하는 음식입니다!";
        comments[11] = "세구세구땅을 건드려보세요!\n말을 합니다! 와! 대박!";
        comments[12] = "음식은 모두 같은 가격입니다.\n어떤 음식이 나오던 개발자는 책임이 없습니다.";
        comments[13] = "세구세구땅이 제일 좋아하는 운동은 숨쉬기운동입니다.\n정말이지 게으르네요!";
        comments[14] = "키의 성장공식은\n(운동 종류+칼로리)x기분%\n이라고 합니다.\n정확한 공식은 고파민 박사만이 알고 있죠.";
        comments[15] = "세구세구땅의 기분이 계속 일정 수치 이하라면\n안좋은 일이 일어날 수 있습니다. 잘 대해주세요.";
        comments[16] = "사실 지금 왼쪽에 있는 침대는\n양쪽 다리의 길이가 다릅니다.";
        comments[17] = "쓴 음식은 몸에 좋은 법입니다.";
        comments[18] = "어떤 분은 하루에 돈을 2000G이상 벌었다고 하더군요.\n세구님은 가능할까요?";
        comments[19] = "이 게임엔 정식엔딩 2개와 히든엔딩 2개가 있습니다.";
        do
        {
            choice = Random.Range(0, comments.Length);
        } while (choice == SecurityPlayerPrefs.GetInt("LastMyComment", -1));
        SecurityPlayerPrefs.SetInt("LastMyComment",choice);
        GetComponent<Text>().text = comments[choice];
    }
}
