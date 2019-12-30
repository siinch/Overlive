using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      float scale = 10000.1f;
      float noise = Mathf.PerlinNoise(transform.parent.position.x * scale, transform.parent.position.y * scale)-0.5f;
      float noise2 = Mathf.PerlinNoise(transform.parent.position.x * scale + 10000.0f, transform.parent.position.y * scale + 10000.0f)-0.5f;
      float noise3 = Mathf.PerlinNoise(transform.parent.position.x * scale, transform.parent.position.y * scale)/2.0f + 0.5f;
      transform.position += new Vector3(noise, noise2, 0);
      transform.localScale *= noise3;
    }

    // Update is called once per frame
    void Update()
    {
      /*
      var player = GenerateTiles.GameMain.player.transform.position;
      var tree = transform.position;
      var size = GenerateTiles.size;
      if(tree.x > player.x + size
      || tree.x <  player.x - size
      || tree.y > player.y + size
      || tree.y < player.y - size)
        Destroy(gameObject);*/
    }
}
