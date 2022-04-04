using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Collisions : MonoBehaviour
{
    public Tilemap tilemap;
    public TilemapRenderer collisionsTilemap;
    // Start is called before the first frame update
    void Start()
    {
        collisionsTilemap.forceRenderingOff = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}