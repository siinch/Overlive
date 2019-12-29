using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileColorPicker : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    /* best big scale ratios so far
    float[] octaves = new float[] {1.0f, 0.1f, 0.025f};
    float[] amplitutes = new float[] {0.05f, 0.25f, 0.7f};
    */
    float[] octaves = new float[] {1.0f, 0.1f, 0.025f, 0.01f};
    float[] amplitutes = new float[] {0.05f, 0.25f, 0.7f, 0.0f};
    float scale = 0.1f; // total scale for all octave ratios
    public static float seed;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        float x = transform.position.x;
        float y = transform.position.y;
        float noise = 0;
        for (int i = 0; i < octaves.Length; i++) {
          noise +=
          amplitutes[i]*(Mathf.PerlinNoise(scale*octaves[i]*x, scale*octaves[i]*y)
          + Mathf.PerlinNoise(seed+scale*octaves[i]*x, seed+scale*octaves[i]*y)) / 2;
        }

        //noise = noise / octaves.Length;

        //noise = (noise + Mathf.PerlinNoise(1000+x, 1000+y)) / 2;

        if(noise < 0.5F)
          spriteRenderer.color = new Color(0, 0, 1);
        else
          spriteRenderer.color = new Color(0, 1, 0);


          //spriteRenderer.color = new Color(noise, noise, noise);
    }

    // Update is called once per frame
    void Update()
    {
      var player = GenerateTiles.GameMain.player.transform.position;
      if(transform.position.x > (player.x + GenerateTiles.size)) {
        Instantiate(GenerateTiles.GameMain.tile, new Vector2(transform.position.x - GenerateTiles.size * 2, transform.position.y), Quaternion.identity);
        Destroy(gameObject);
        this.enabled = false;
      }
      else if(transform.position.x < (player.x - GenerateTiles.size)) {
        Instantiate(GenerateTiles.GameMain.tile, new Vector2(transform.position.x + GenerateTiles.size * 2, transform.position.y), Quaternion.identity);
        Destroy(gameObject);
        this.enabled = false;
      }
      else if(transform.position.y < (player.y - GenerateTiles.size)) {
        Instantiate(GenerateTiles.GameMain.tile, new Vector2(transform.position.x, transform.position.y + GenerateTiles.size * 2), Quaternion.identity);
        Destroy(gameObject);
        this.enabled = false;
      }
      else if(transform.position.y > (player.y + GenerateTiles.size)) {
        Instantiate(GenerateTiles.GameMain.tile, new Vector2(transform.position.x, transform.position.y - GenerateTiles.size * 2), Quaternion.identity);
        Destroy(gameObject);
        this.enabled = false;
      }
      /*if(Vector3.Distance(transform.position, player) > 100)
        Destroy(gameObject);
        this.enabled = false;*/
    }
}
