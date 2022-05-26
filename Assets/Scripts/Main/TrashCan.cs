using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Food"&&GameManager.instance.Hold==false)
        {
            Destroy(collision.gameObject);
            SecurityPlayerPrefs.DeleteKey("Readykcal");
        }
    }
}
