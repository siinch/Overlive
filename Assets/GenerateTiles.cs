using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTiles : MonoBehaviour
{
    public static GenerateTiles GameMain;
    public static int size = 8;
    int xbegin;
    int ybegin;
    int xend;
    int yend;
    public GameObject tile;
    public GameObject player;
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
      GameMain = this;
      xbegin = -size;
      ybegin = -size;
      xend = size;
      yend = size;

      TileColorPicker.seed = 834961.3f;// Random.Range(-999999.0F, 999999.0F);
      TileColorPicker.seed2 = -259641.5f;//Random.Range(-999999.0F, 999999.0F);
      Debug.Log(TileColorPicker.seed + " " + TileColorPicker.seed2);
      for(int x = xbegin; x <= xend; x++)
        for(int y = ybegin; y <= yend; y++)
          Instantiate(tile, new Vector3(x, y, y), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
