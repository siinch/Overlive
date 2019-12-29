using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      transform.position += new Vector3(Random.Range(0.0f, 0.5f), Random.Range(0.0f, 0.5f), 0);
      transform.localScale -= new Vector3(Random.Range(0.0f, 0.3f), Random.Range(0.0f, 0.3f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, GenerateTiles.GameMain.player.transform.position) > 15)
          Destroy(gameObject);
    }
}
