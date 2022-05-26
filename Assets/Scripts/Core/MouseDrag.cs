using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    Camera cam;
    private void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    private void OnMouseDrag()
    {
        Vector3 MousePoint = new Vector3(Input.mousePosition.x,Input.mousePosition.y,0);
        transform.position = cam.ScreenToWorldPoint(MousePoint+new Vector3(0,0,20));
        GameManager.instance.Hold = true;
    }

    private void OnMouseUp()
    {
        GameManager.instance.Hold = false;
    }
}
