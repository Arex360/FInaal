using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{
    
    int score=0;
    private Rigidbody2D rb;
    public float speed = 5f;
    public FixedJoystick joystick;
    public PhotonView view;
  //  AudioSource m_MyAudioSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
        if (view.IsMine)
        {
            joystick = FindObjectOfType<FixedJoystick>();
        }
       // m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            
            move();
        }

    }
    

   public void move()
    {
        // private float horizontal = joystick.Horizontal;


         float inputx = Input.GetAxis("Horizontal") + joystick.Horizontal;
      //  float inputX = joystick.Horizontal();
      
        if ( inputx !=0)
        {

            Debug.Log(joystick.Horizontal);
            var moveDir = (transform.right * speed)  * inputx;
            transform.Translate(moveDir * Time.deltaTime);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Egg"))
        {
            Destroy(collision.gameObject);
            textscore.score_value++;
            Debug.Log(textscore.score_value);
            // m_MyAudioSource.Play();
            if (textscore.score_value == 100)
            {
                SceneManager.LoadScene("Win");

            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            textscore.score_value = textscore.score_value+10;
            Debug.Log(textscore.score_value);
            if (textscore.score_value == 100)
            {
                SceneManager.LoadScene("Win");

            }
            //  m_MyAudioSource.Play();

        }
        if(collision.gameObject.CompareTag("Kill"))
        { 
            SceneManager.LoadScene("Gameover");
        }

    }
}
