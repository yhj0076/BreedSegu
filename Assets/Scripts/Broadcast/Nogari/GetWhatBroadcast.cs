using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GetWhatBroadcast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SecurityPlayerPrefs.SetInt("Broadcast", SceneManager.GetActiveScene().buildIndex);
    }
}
