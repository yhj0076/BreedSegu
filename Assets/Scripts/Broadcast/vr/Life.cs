using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject goba;
    public GameObject heart;
    public int lifeCount;
    public bool end;
    Vector2 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        end = false;
        lastPos = transform.position;
        for (int i = 0; i < lifeCount; i++)
        {
            GameObject.Instantiate(heart,new Vector2(lastPos.x-i*1.1f,lastPos.y),Quaternion.identity).transform.parent = transform;
        }
    }

    public void Damage()
    {
        lifeCount--;
        if(lifeCount>0)
        {
            Destroy(transform.GetChild(lifeCount).gameObject);
        }
        else if(lifeCount==0)
        {
            Destroy(transform.GetChild(lifeCount).gameObject);
            end = true;
            goba.SetActive(true);
        }
    }
}
