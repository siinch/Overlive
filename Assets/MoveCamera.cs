using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    float speed = 10F; //2.5
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = gameObject.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
      float x = Input.GetAxisRaw("Horizontal");
      float y = Input.GetAxisRaw("Vertical");
      Vector3 input = new Vector3(x, y, 0).normalized;

      //transform.position = transform.position + input * speed * Time.deltaTime;
      rb.velocity = input * speed;
      transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }
}
