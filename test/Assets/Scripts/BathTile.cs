using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathTile : Tile
{
    public override void DogOnTrigger(GameObject obj) {
        Debug.Log("Dog is washed");
        obj.GetComponent<DogState>().CleanState = true;
    }

    public override void PlayerOnTrigger(GameObject obj)
    {
        return;
    }
}
