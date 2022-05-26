﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            transform.parent.parent.GetComponent<ObstacleGenerator>().stop = true;
            Destroy(collision.gameObject);
        }
    }
}
