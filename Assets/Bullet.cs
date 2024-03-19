using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float Speed = 7.0f;
 
    // Start is called before the first frame update
    void Start()
    {
  
        Destroy(gameObject, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.rotation.x, transform.rotation.y, 0f);
        //transform.Translate(Time.deltaTime * Vector3.up * Speed);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * Vector3.right * Speed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Time.deltaTime * Vector3.down * Speed);
        } 
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Time.deltaTime * Vector3.left * Speed);
        }
        else
        {
            transform.Translate(Time.deltaTime * Vector3.up * Speed);
        }

    }
}
