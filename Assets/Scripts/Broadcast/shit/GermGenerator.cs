using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermGenerator : MonoBehaviour
{
    public GameObject Germ;
    public GameObject Germs;
    float time = 0;
    float Gentime = 0;
    float GentimeUp = 3;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        Gentime = 0;
        GentimeUp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Gentime += Time.deltaTime;
        if (time > 2f)
        {
            GentimeUp -= 0.1f;
            time = 0;
        }

        if (Gentime > GentimeUp)
        {
            transform.parent.rotation = Quaternion.Euler(0,0,Random.Range(0,360));
            GameObject.Instantiate(Germ, transform.position, Quaternion.identity).transform.parent = Germs.transform;
            Gentime = 0;
        }
    }
}
