using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
   public GameObject PlayerPrefab;
    public float minX, maxX;
    public float minY, maxY;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Vector2 randomplayer = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(PlayerPrefab.name, randomplayer,Quaternion.identity);
        PlayerMove[] players = FindObjectsOfType<PlayerMove>();
        bool mine = false;
        foreach(PlayerMove player in players)
        {
            if (player.view.IsMine)
            {
                if (!mine)
                {
                    mine = true;
                }
                else
                {
                    PhotonNetwork.Destroy(player.gameObject);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
