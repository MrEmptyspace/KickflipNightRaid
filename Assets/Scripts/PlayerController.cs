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
        if ((Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.5) || (Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.5))
        {
            Vector2 move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            move = move.normalized * Time.deltaTime * moveSpeed;//walkspeed, runspeed, etc.
            transform.Translate(move);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }


        // anim.SetFloat("MoveX",Input.GetAxisRaw("Horizontal"));
        // anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        //anim.SetBool("PlayerMoving", playerMoving);
        // anim.SetFloat("LastMoveX", lastMove.x);
        //anim.SetFloat("LastMoveY", lastMove.y);
    }
}
