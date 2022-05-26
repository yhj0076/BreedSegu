using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffRoll : MonoBehaviour
{
    public GameObject gotoMain;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0,-20.8f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 14.55)
        {
            if (Input.anyKey)
            {
                rigid.velocity = Vector2.up * 5;
            }
            else
            {
                rigid.velocity = Vector2.up * 1;
            }
        }
        else
        {
            rigid.velocity = Vector2.zero;
            gotoMain.SetActive(true);
            Destroy(this);
        }
    }
}
