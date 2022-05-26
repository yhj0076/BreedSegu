using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag=="note")
        {
            //FindObjectOfType<Life>().Damage();
            Destroy(collision.gameObject);
        }
    }
}
