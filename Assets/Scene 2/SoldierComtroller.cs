using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SoldierComtroller : MonoBehaviour
{
    Animator animator; //create a refernce to Animator type
    SpriteRenderer spriteRenderer;
    [SerializeField] float Speed = 1.0f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Vector3 gun;
    bool right, left, up, down;

    // Start is called before the first frame update
    void Start()
    {
        right = false;
        left = false;
        up = false;
        down = false;
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
            down = true;
            right = false;
            left = false;
            up = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow)) {
            animator.SetBool("Up", true);
            transform.Translate(Time.deltaTime * Vector3.up * Speed);
            up = true;
            right = false;
            left = false;
            down = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Right", true); //set the "Right" parameter to true and dont flip
            spriteRenderer.flipX = true;
            transform.Translate(Time.deltaTime * Vector3.left * Speed);
            left = true;
            right = false;
            down = false;
            up = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Right", true); //set the "Right" parameter to true but dont flip
            spriteRenderer.flipX = false;
            transform.Translate(Time.deltaTime * Vector3.right * Speed);
            right = true;
            up = false;
            left = false;
            down = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject Bullet =   Instantiate(bulletPrefab, transform.position, transform.rotation);
            // if the player is pointing to the right, dont rotate
            //if the player is pointing up, rotate my 90 degrees
            //if the player is pointing down rotate -90
      
                if (right == true)
                {
                    
                    //stantiate(bulletPrefab, transform.position, transform.rotation);
                    Bullet.transform.Rotate(0, 0, -90f);
                }
                else if (left == true)
                {
                    
                    // Instantiate(bulletPrefab, transform.position, transform.rotation);
                    Bullet.transform.Rotate(0, 0, 90f);
                }
                else if (down == true)
                {
                  
                    //Instantiate(bulletPrefab, transform.position, transform.rotation);
                    Bullet.transform.Rotate(0, 0, 180f);
                }
                else if (up == true)
                {
                    
                   
                }


            }
        }
        // else
        //  {
        //animator.SetBool("Right", false); //set the "Right" parameter to false
        // spriteRenderer.flipX = false;
        // }
    }
