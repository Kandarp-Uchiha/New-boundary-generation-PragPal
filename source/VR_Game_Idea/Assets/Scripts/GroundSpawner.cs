using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTileOrange, groundTileBlue;
    bool orangeTileType = true; // orangeTileType = true(for orange tile), = false(for blue tile)
    Vector3 nextSpawnPoint;

    public void spawnTile()
    {
        if(orangeTileType)
        {
            GameObject temp = Instantiate(groundTileOrange,nextSpawnPoint,Quaternion.identity);
            nextSpawnPoint = temp.transform.GetChild(3).transform.position;
        }
        else
        {
            GameObject temp = Instantiate(groundTileBlue,nextSpawnPoint,Quaternion.identity);
            nextSpawnPoint = temp.transform.GetChild(3).transform.position;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            spawnTile();
        }
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            orangeTileType = !orangeTileType;
        }
    }

   
}
