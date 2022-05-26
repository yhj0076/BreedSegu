using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolutionGAGE : MonoBehaviour
{
    public GameObject nogari;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "고라니(Clone)")
        {
            nogari.GetComponent<Nogari>().hurt++;
            Destroy(collision.gameObject);
        }
    }
}
