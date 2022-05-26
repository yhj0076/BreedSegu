using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodChat : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        Destroy(gameObject,10);
    }
    private void OnMouseDown()
    {
        if (SecurityPlayerPrefs.GetInt("EarnedMoney", -999)>0)
        {
            switch(SecurityPlayerPrefs.GetInt("EarnedMoney",-999))
            {
                case 2:
                    SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -999) - 2);
                    break;
                case 1:
                    SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -999) - 1);
                    break;
                default:
                    SecurityPlayerPrefs.SetInt("EarnedMoney", SecurityPlayerPrefs.GetInt("EarnedMoney", -999) - 3);
                    break;
            }
        }
        Destroy(gameObject);
    }
}
