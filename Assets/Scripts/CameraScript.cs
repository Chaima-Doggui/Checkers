using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] SpriteRenderer tile;
    // Start is called before the first frame update
    void Start()
    {
        var screenR = Screen.width/ Screen.height;
        var targetR = tile.bounds.size.x / tile.bounds.size.y;
        // tile.bounds.size.y * 8 =heightÓfTile*8 =heightOfGridManager
        //this formula if we want to ajust only the width of our borad to the width of the screen 
        // Camera.main.orthographicSize = ((tile.bounds.size.x*8 )* Screen.height / Screen.width) / 2;

        if (screenR>=targetR)
        {
           Camera.main.orthographicSize = (tile.bounds.size.y * 11)/ 2 ;
           
        
        }
        else
        {
            Camera.main.orthographicSize = (tile.bounds.size.y * 8) / 2 * (targetR / screenR);
            
        }

        // Camera.main.orthographicSize = (tile.bounds.size.y * 8) / 2;

    }

    // Update is called once per frame

}
