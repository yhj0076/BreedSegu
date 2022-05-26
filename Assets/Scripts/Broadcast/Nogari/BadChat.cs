using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadChat : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left*speed;
    }
    private void OnMouseDown()
    {
        SecurityPlayerPrefs.SetInt("EarnedMoney",SecurityPlayerPrefs.GetInt("EarnedMoney",-999)+10);
        FindObjectOfType<KKangSound>().hit = true;
        Destroy(gameObject);
    }
}
