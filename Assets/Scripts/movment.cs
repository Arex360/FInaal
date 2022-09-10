using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class movment : MonoBehaviour
{
        [SerializeField] private float directionDampTime = 0.25f;
       // private Animator animator;
        public Joystick joystick;
        PhotonView View;
    void Start()
        {
            View = GetComponent<PhotonView>();
            

          //  joystick = FindObjectOfType<Joystick>();
        }

        void Update()
        {
            if (View.IsMine == false && PhotonNetwork.IsConnected == true)
            {
                return;
            }


            float h = joystick.Horizontal;
            float v = joystick.Vertical;

            if (v < 0)
            {
                v = 0;
            }

          //  animator.SetFloat("Speed", h * h + v * v);
           // animator.SetFloat("Direction", h, directionDampTime, Time.deltaTime);
        }

    
}
