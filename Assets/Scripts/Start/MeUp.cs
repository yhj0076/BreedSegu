using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeUp : MonoBehaviour
{
    RectTransform rect;
    public bool Up;
    public GameObject TalkBallon;
    void Start()
    {
        Up = true;
        rect = GetComponent<RectTransform>();
        Invoke("BallonOn",1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Up)
        {
            //rect.localPosition = Vector2.Lerp(rect.localPosition,new Vector2(0,-226),0.08f);
        }
        else
        {
            //rect.localPosition = Vector2.Lerp(rect.localPosition,new Vector2(0,-709),0.08f);
            StartCoroutine("NextScene");
        }
    }

    void BallonOn()
    {
        TalkBallon.SetActive(true);
    }
    
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(Mathf.PI/2+0.1f);
        GameManager.instance.SceneSelect(2);
        StopCoroutine("NextScene");
    }
}
