using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class ButtonController : MonoBehaviour
{
    public GameObject ExerWindow;
    public GameObject FoodGenerator;
    public GameObject ErrorFood;
    public GameObject NotEnoughMoney;
    [SerializeField]
    public GameObject[] Foods;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Start()
    {
        SecurityPlayerPrefs.SetFloat("LastHeight",SecurityPlayerPrefs.GetFloat("Height",-1));
        SecurityPlayerPrefs.SetInt("Broadcast", 0);
        switch (SecurityPlayerPrefs.GetInt("Readykcal", 0))
        {
            case 0:     // 있던 음식 없음
                break;
            case 10:    // 컵라면 생성
                GameObject.Instantiate(Foods[3], FoodGenerator.transform.position, Quaternion.identity).transform.parent = FoodGenerator.transform;
                break;
            case 15:    // 붕어빵 생성
                GameObject.Instantiate(Foods[1], FoodGenerator.transform.position, Quaternion.identity).transform.parent = FoodGenerator.transform;
                break;
            case 20:    // 만두 생성
                GameObject.Instantiate(Foods[0], FoodGenerator.transform.position, Quaternion.identity).transform.parent = FoodGenerator.transform;
                break;
            case 50:    // 원칩 생성
                GameObject.Instantiate(Foods[2], FoodGenerator.transform.position, Quaternion.identity).transform.parent = FoodGenerator.transform;
                break;
            case 80:    // 밀웜 생성
                GameObject.Instantiate(Foods[4], FoodGenerator.transform.position, Quaternion.identity).transform.parent = FoodGenerator.transform;
                break;
            case 100:   // 연어초밥 생성
                GameObject.Instantiate(Foods[5], FoodGenerator.transform.position, Quaternion.identity).transform.parent = FoodGenerator.transform;
                break;
        }
    }

    public void _MakeFood()
    {
        GetComponent<AudioSource>().Play();
        if (GameObject.FindGameObjectWithTag("Food")!=null)
        {
            if (ErrorFood.activeSelf == false)
            {
                ErrorFood.SetActive(true);
            }
            else
            {
                ErrorFood.GetComponent<ErrorFood>().time = 0;
            }
        }
        else if(SecurityPlayerPrefs.GetInt("Money",-9999)<20)
        {
            if (NotEnoughMoney.activeSelf == false)
            {
                NotEnoughMoney.SetActive(true);
            }
            else
            {
                NotEnoughMoney.GetComponent<ErrorFood>().time = 0;
            }
        }
        else
        {
            float rand = Random.Range(0f, 100f);
            int choice = 0;
            if (rand < 19.8f)
            {
                choice = 0;
            }else if(rand < 39.6f)
            {
                choice = 1;
            }else if(rand < 59.4f)
            {
                choice = 2;
            }else if(rand < 79.2)
            {
                choice = 3;
            }else if(rand < 99f)
            {
                choice = 4;
            }
            else
            {
                choice = 5;
            }
            GameObject.Instantiate(Foods[choice], FoodGenerator.transform.position, Quaternion.identity).transform.parent = FoodGenerator.transform;
            SecurityPlayerPrefs.SetInt("Money", SecurityPlayerPrefs.GetInt("Money",-9999)-20);
            switch (choice)
            {
                case 0:     // 만두
                    SecurityPlayerPrefs.SetInt("Readykcal", 20);
                    break;                      
                case 1:     // 붕어빵           
                    SecurityPlayerPrefs.SetInt("Readykcal", 15);
                    break;                      
                case 2:     // 원칩             
                    SecurityPlayerPrefs.SetInt("Readykcal", 50);
                    break;                      
                case 3:     // 컵라면           
                    SecurityPlayerPrefs.SetInt("Readykcal", 10);
                    break;                      
                case 4:     // 밀웜             
                    SecurityPlayerPrefs.SetInt("Readykcal", 80);
                    break;
                case 5:     // 연어초밥
                    SecurityPlayerPrefs.SetInt("Readykcal", 100);
                    break;
            }
        }
    }

    public void _Yoga()
    {
        GetComponent<AudioSource>().Play();
        //Debug.Log("운동했다");
        int ExerciseChoice = Random.Range(0,4);
        /*
         * 운동 목록
         * 1. 숨쉬기 운동
         * 2. 달리기
         * 3. 필라테스
         * 4. 줄넘기
         */
        switch (ExerciseChoice)
        {
            case 0:     // 숨쉬기 운동
                SecurityPlayerPrefs.SetFloat("Exercise", 0);
                break;
            case 1:     // 달리기
                SecurityPlayerPrefs.SetFloat("Exercise", 1);
                break;
            case 2:     // 필라테스
                SecurityPlayerPrefs.SetFloat("Exercise", 5);
                break;
            case 3:     // 줄넘기
                SecurityPlayerPrefs.SetFloat("Exercise", 3);
                break;
        }
        ExerWindow.SetActive(true);
        
    }

    void Grow()
    {
        Debug.Log("키컸다");
        float TallSize = (SecurityPlayerPrefs.GetFloat("Exercise", 0) + (SecurityPlayerPrefs.GetInt("kcal", 0) / 75)) * (SecurityPlayerPrefs.GetFloat("Feeling", 0) / 100);
        SecurityPlayerPrefs.SetFloat("Height", SecurityPlayerPrefs.GetFloat("Height", -1) + TallSize);
        if (SecurityPlayerPrefs.GetFloat("Feeling", 0) > 0)
        {
            GameManager.instance.Feel_UpDown(-10);
        }
        SecurityPlayerPrefs.SetInt("kcal", 0);
        FindObjectOfType<EatBox_Size>().changeScale();
        FeelingControl();
    }

    void FeelingControl()
    {
        if(SecurityPlayerPrefs.GetFloat("Feeling", 0)<=0)
        {
            SecurityPlayerPrefs.SetFloat("Feeling", 0);
        }
    }
}
