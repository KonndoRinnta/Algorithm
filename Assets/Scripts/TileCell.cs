using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCell : MonoBehaviour
{
    [SerializeField] List<TileCell> borderOnTiles;
    [SerializeField] int needStep = 1;
    public void SetStep(int count)
    {
        if (count <= 0)
        {
            return;
        }
        foreach (var tile in borderOnTiles)
        {
            tile.SetStep(count - needStep);
        }
    }
}