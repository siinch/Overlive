using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var player = GenerateTiles.GameMain.player.transform.position;
        transform.position = new Vector3(player.x, player.y, player.y - 10.0f);
    }
}
