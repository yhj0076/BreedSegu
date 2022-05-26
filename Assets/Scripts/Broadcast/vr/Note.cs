using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float NoteSpeed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * NoteSpeed;
    }

    //private void Update()
    //{
    //    if(Life.GetComponent<Life>().end)
    //    {
    //        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    //    }
    //}
}
