using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour
{
    Vector2 MousePosition;
    Camera cam;
    public GameObject goba;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.timeScale == 1 && goba.activeSelf == false)
        {
            Cursor.visible = false;
            MousePosition = Input.mousePosition;
            MousePosition = cam.ScreenToWorldPoint(MousePosition);
            transform.position = MousePosition;
        }
        else if(Time.timeScale == 0 && goba.activeSelf == false)
        {
            Cursor.visible = true;
        }
        else if(goba.activeSelf == true)
        {
            Cursor.visible = true;
            Destroy(gameObject);
        }
    }
}
