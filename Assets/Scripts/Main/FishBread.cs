using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBread : MonoBehaviour
{
    public float FeelControl;
    // Start is called before the first frame update
    void Start()
    {
        int choice = Random.Range(0,2);
        if(choice == 0)
        {
            FeelControl = 15;    //슈붕
        }
        else
        {
            FeelControl = -15;//팥붕
        }
    }
}
