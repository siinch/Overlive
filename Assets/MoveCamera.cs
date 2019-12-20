using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    float speed = 10.0F;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
      float x = Input.GetAxisRaw("Horizontal");
      float y = Input.GetAxisRaw("Vertical");
      Vector3 input = new Vector3(x, y, 0).normalized;

      transform.position = transform.position + input * speed * Time.deltaTime;
    }
}
