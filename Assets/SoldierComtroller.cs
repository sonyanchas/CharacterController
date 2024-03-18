using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierComtroller : MonoBehaviour
{
    Animator animator; //create a refernce to Animator type
    SpriteRenderer spriteRenderer;
    float Speed = 1.0f;
    GameObject bulletPrefab;
    Vector3 gun;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //Get a reference to the component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Up", false);
        animator.SetBool("Down", false);
        animator.SetBool("Right", false);
        //animator.SetBool("Right", Input.GetKey(KeyCode.RightArrow));
        //animator.SetBool("Up", Input.GetKey(KeyCode.UpArrow));
        //animator.SetBool("Down", Input.GetKey(KeyCode.DownArrow));
        if (Input.GetKey(KeyCode.DownArrow)) {
            animator.SetBool("Down", true);
            transform.Translate(Time.deltaTime * Vector3.down * Speed);
        }
        else if (Input.GetKey(KeyCode.UpArrow)) {
            animator.SetBool("Up", true);
            transform.Translate(Time.deltaTime * Vector3.up * Speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Right", true); //set the "Right" parameter to true and dont flip
            spriteRenderer.flipX = true;
            transform.Translate(Time.deltaTime * Vector3.left * Speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Right", true); //set the "Right" parameter to true but dont flip
            spriteRenderer.flipX = false;
            transform.Translate(Time.deltaTime * Vector3.right * Speed);
        }
        if (Input.GetKeyDown(KeyCode.Space)) //When Fire1 button is hit, heartprefab is instantiated
        {
            Instantiate(bulletPrefab, transform.position + gun, transform.rotation);
        }
        // else
        //  {
        //animator.SetBool("Right", false); //set the "Right" parameter to false
        // spriteRenderer.flipX = false;
        // }
    }
}
