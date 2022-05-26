using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    float speed;
    void Start()
    {
        speed = 3;
        GetComponent<Rigidbody2D>().velocity = Vector2.left*speed;
    }

    private void Update()
    {
        if(transform.parent.GetComponent<ObstacleGenerator>().stop)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        
        if(transform.position.x<-8)
        {
            Destroy(gameObject);
        }
    }
}
