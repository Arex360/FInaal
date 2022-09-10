using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offline: MonoBehaviour
{
    //int score=0;
    private Rigidbody2D rb;
    public float speed = 1f;
   // public Transform Player;
   
    public Joystick joystick;
    private float horizontalinput;
    private float verticalinput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
    
        
            move();
        

    }
    public void move()
    {
        horizontalinput = joystick.Horizontal;
        verticalinput = joystick.Vertical;


        float inputX = Input.GetAxis("Horizontal");
      // float inputX=  variableJoystick.Vertical

        if (inputX != 0 || horizontalinput != 0)
        {
            Debug.Log(horizontalinput);

            var moveDir = (transform.right * speed) * horizontalinput;
            transform.Translate(moveDir * Time.deltaTime);
        }
        float inputy = Input.GetAxis("Vertical");
        Debug.Log(verticalinput);
        if (inputy != 0 || verticalinput != 0)
        {
            var moveDir = (transform.up * speed) * verticalinput;
            transform.Translate(moveDir * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            textscore.score_value++;
            Debug.Log(textscore.score_value);
        }
    }
}
