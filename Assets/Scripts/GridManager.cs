using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int widthBoard, heightBoard;
    [SerializeField] private Tile tile;
    [SerializeField] private Transform mCamera;

    void GenerateGrid()
    {
        for(int x=0; x < widthBoard; x++ )
            for(int y=0; y <heightBoard; y++)
            {
                var spawnedTile = Instantiate(tile,new Vector3(x,y),Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";


                //(even+even)%2=0  (odd+odd)%2=0 (even+odd)%2=1
                //idha kenha tile de base f chessboard (elli hiya genneralement tkoun fl position X w Y mteeha zouz zawji wala zouz fardi) aateha l couleur principal
                //idha kenha tile offset (x=zawji, y=fardi wala laaks) aateha l couleur offset
              
                var isOffset = ((x + y) % 2==1) ? true : false ;
                spawnedTile.Init(isOffset);
            }

       
        mCamera.position = new Vector3(widthBoard/2 - 0.5f, heightBoard /2 - 0.5f, -10);
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
