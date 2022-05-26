using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;
    public float GenTime;
    public bool stop;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            time += Time.deltaTime;
            if (time > GenTime)
            {
                GameObject.Instantiate(obstacle, new Vector3(transform.position.x, transform.position.y - Random.Range(-3f, 3f),transform.position.z), Quaternion.identity).transform.parent = transform;
                time = 0;
            }
        }
    }
}
