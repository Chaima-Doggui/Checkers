using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor,offsetColor;
    [SerializeField] private SpriteRenderer spriteRenderr;
    [SerializeField] private GameObject highlight;
    // Start is called before the first frame update
   public void Init(bool isOffset)
    {
        spriteRenderr.color = isOffset ? offsetColor : baseColor;
    }

    // Update is called once per frame
    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }
}
