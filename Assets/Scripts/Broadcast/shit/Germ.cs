using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germ : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = (GameObject.Find("GSG").transform.position - transform.position).normalized*speed;
        Destroy(gameObject,5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "GSG")
        {
            collision.GetComponent<seguMoving>().hit = true;
            Destroy(gameObject);
        }
    }
}
