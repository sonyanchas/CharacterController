using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheroController : MonoBehaviour
{
    Animator animator; //create a refernce to Animator type
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //Get a reference to the component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("Right", Input.GetKey(KeyCode.RightArrow));
        animator.SetBool("Up", Input.GetKey(KeyCode.UpArrow));
        animator.SetBool("Down", Input.GetKey(KeyCode.DownArrow));
        if (Input.GetKey(KeyCode.UpArrow))
        {

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Right", true); //set the "Right" parameter to true and dont flip
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Right", true); //set the "Right" parameter to true but dont flip
            spriteRenderer.flipX = false;
        }
        else
        {
            animator.SetBool("Right", false); //set the "Right" parameter to false
            spriteRenderer.flipX = false;
        }
    }
}
