using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingSegu : MonoBehaviour
{
    public GameObject goba;
    public GameObject DieSound;
    public GameObject SoundManager;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid.velocity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            rigid.AddForce(Vector2.up*40);
        }

        if(rigid.velocity.y>5)
        {
            rigid.velocity = new Vector2(0, 5);
        }
    }

    private void OnDisable()
    {
        DieSound.SetActive(true);
        goba.SetActive(true);
        SoundManager.GetComponent<AudioSource>().Stop();
    }
}
