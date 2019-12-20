using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTiles : MonoBehaviour
{
    int size = 100;
    int xbegin;
    int ybegin;
    int xend;
    int yend;
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
      xbegin = -size;
      ybegin = -size;
      xend = size;
      yend = size;

      TileColorPicker.seed = Random.Range(-999999.0F, 999999.0F);
      for(int x = xbegin; x <= xend; x++)
        for(int y = ybegin; y <= yend; y++)
          Instantiate(tile, new Vector2(x, y), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
