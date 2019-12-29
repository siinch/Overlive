using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTiles : MonoBehaviour
{
    public static GenerateTiles GameMain;
    public static int size = 10;
    int xbegin;
    int ybegin;
    int xend;
    int yend;
    public GameObject tile;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      GameMain = this;
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
