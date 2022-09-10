using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ChatManger1 : MonoBehaviour
{
    [SerializeField] GameObject gameobject;
    public GameObject chatRoom;
    // Start is called before the first frame update
    void Start()
    {
        gameobject.SetActive(true);
        chatRoom.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chatscene()
    {
       gameobject.SetActive(true);
    }
}
