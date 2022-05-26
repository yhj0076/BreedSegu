using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowSize : MonoBehaviour
{
    Text size;
    // Start is called before the first frame update
    void Start()
    {
        size = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float height = SecurityPlayerPrefs.GetFloat("Height",-1);
        if(betweenSize(height,1.2f,1.43f))
        {
            size.text = "현재 크기 : 보노보 침팬지급";
        }
        else if(betweenSize(height,1.43f,1.58f))
        {
            size.text = "현재 크기 : 페리도트 그린급";
        }
        else if(betweenSize(height,1.58f,1.6f))
        {
            size.text = "현재 크기 : 아이네급";
        }
        else if(betweenSize(height,1.6f,1.61f))
        {
            size.text = "현재 크기 : 비챤급";
        }
        else if(betweenSize(height,1.61f,1.62f))
        {
            size.text = "현재 크기 : 징버거급";
        }
        else if(betweenSize(height,1.62f,1.64f))
        {
            size.text = "현재 크기 : 주르르급";
        }
        else if(betweenSize(height,1.64f,1.777f))
        {
            size.text = "현재 크기 : 릴파급";
        }
        else if(betweenSize(height,1.777f,24))
        {
            size.text = "현재 크기 : 우왁굳급";
        }
        else if(betweenSize(height,24,107))
        {
            size.text = "현재 크기 : 왁리오급";
        }
        else if(betweenSize(height,107,300))
        {
            size.text = "현재 크기 : 카멘타이탄급";
        }
        else
        {
            size.text = "현재 크기 : 고세구급";
        }
    }

    bool betweenSize(float height,float h1, float h2)
    {
        if (height >= h1 && height < h2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
