using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemyspawn : MonoBehaviour
{
   public GameObject Enemy;
    
    
    float randx;
    Vector2 wheretospawn;
    public float spawnrate=2;
    float nextspawn;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextspawn)
        {
            nextspawn = Time.time+ spawnrate;
            randx = Random.Range(-6.46f, 6.46f);
            wheretospawn= new Vector2(randx,transform.position.y);
            Instantiate(Enemy,wheretospawn,Quaternion.identity);
        }
    }
    
}
