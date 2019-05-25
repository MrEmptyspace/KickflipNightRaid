using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour  
{

    public float moveSpeed;
    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMoving = false;
        if(Input.GetAxisRaw("Horizontal") > 0.5 || Input.GetAxisRaw("Horizontal") < -0.5)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f,0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0F);

        }

        if (Input.GetAxisRaw("Vertical") > 0.5 || Input.GetAxisRaw("Vertical") < -0.5)
        {
            transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            playerMoving = true;
            lastMove = new Vector2(0F, Input.GetAxisRaw("Vertical"));
        }

       // anim.SetFloat("MoveX",Input.GetAxisRaw("Horizontal"));
       // anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        //anim.SetBool("PlayerMoving", playerMoving);
       // anim.SetFloat("LastMoveX", lastMove.x);
        //anim.SetFloat("LastMoveY", lastMove.y);
    }
}
