using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguMoving : MonoBehaviour
{
    Rigidbody2D rigid;
    public GameObject goba;
    public GameObject GermGen;
    public GameObject DieSound;
    public GameObject BGM;
    public float speed;
    public bool hit;
    float speedX;
    float speedY;
    // Start is called before the first frame update
    void Start()
    {
        hit = false;
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hit == false)
        {
            //좌우
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //rigid.velocity = Vector2.left * speed;
                speedX = -speed;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                //rigid.velocity = Vector2.right * speed;
                speedX = speed;
            }
            else
            {
                //rigid.velocity = Vector2.zero;
                speedX = 0;
            }
            //상하
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //rigid.velocity = Vector2.up * speed;
                speedY = speed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                //rigid.velocity = Vector2.down * speed;
                speedY = -speed;
            }
            else
            {
                //rigid.velocity = Vector2.zero;
                speedY = 0;
            }
            //대각
            if (speedX != 0 && speedY != 0)
            {
                speedX = speedX / Mathf.Sqrt(2);
                speedY = speedY / Mathf.Sqrt(2);
            }
            rigid.velocity = new Vector2(speedX, speedY);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        //SecurityPlayerPrefs.SetInt("Money",SecurityPlayerPrefs.GetInt("Money",-1)+SecurityPlayerPrefs.GetInt("EarnedMoney",-1));
        FindObjectOfType<MoneyEarn_shit>().GetBoost = false;
        DieSound.SetActive(true);
        BGM.SetActive(false);
        GermGen.SetActive(false);
        goba.SetActive(true);
    }
}
