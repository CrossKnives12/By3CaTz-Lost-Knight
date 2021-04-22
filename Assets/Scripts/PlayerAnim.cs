using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator anim;
    PlayerController apc;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        apc = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(apc.playerRun == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isRunning", false);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                 anim.SetTrigger("Jump");
            }
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
}
