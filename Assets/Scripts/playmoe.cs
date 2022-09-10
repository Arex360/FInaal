using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmoe : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private bool movel, mover, moveu, moved;
    private float horizontalinput;
    private float verticalinput;
    public Transform Player;
    public Joystick joystick;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate()
    {
        Vector2 inputs = new Vector2(joystick.Horizontal, joystick.Vertical);
        rb.MovePosition((Vector2)this.transform.position + new Vector2(inputs.x * speed * Time.fixedDeltaTime, inputs.y * speed * Time.fixedDeltaTime));

    }
    public void moveL()
    {
        movel = true;

    }
    public void moveR()
    {
        mover = true;

    }
    public void moveD()
    {
        moved = true;

    }
    public void moveU()
    {
        moveu = true;

    }
    public void SMove()
    {
        mover = false;
        movel = false;
        moveu = false;
        moved = false;
    }


}
