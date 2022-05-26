using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatGenerator : MonoBehaviour
{
    [SerializeField]
    public GameObject[] Chats;

    double time = 0;
    int beforePos;
    int YPos;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>0.2f)
        {
            do
            {
                YPos = Random.Range(-3, 4);
            } while (YPos == beforePos);
            beforePos = YPos;
            GameObject.Instantiate(Chats[Random.Range(0, Chats.Length)],transform.position+new Vector3(0,YPos,0),Quaternion.identity).transform.parent = transform;
            time -= 0.5f;
        }
    }
}
