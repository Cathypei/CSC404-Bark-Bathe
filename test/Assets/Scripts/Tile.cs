using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile: MonoBehaviour
{
    BoxCollider tileCollider;
    HashSet<GameObject> entered;
    Vector3 tileCenter;
    Vector3 tileSize;
    private void Start()
    {
        if (InitCollider()) {
            Destroy(gameObject);
        }
    }
    private bool InitCollider() {
        tileCollider = gameObject.GetComponent<BoxCollider>();
        if (tileCollider == null)
        {
            Debug.Log("Tile has no collider associated");
            return true;
        }
        tileCenter = tileCollider.center;
        tileSize = Vector3.Scale(tileCollider.size, transform.lossyScale);
        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("An Object Enters");
        GameObject collided = other.gameObject;
        if (collided.tag.Equals("Dog")) {
            DogOnTrigger(collided);
            return;
        }
        if (collided.tag.Equals("Player")) {
            PlayerOnTrigger(collided);
            return;
        }
        Debug.Log("Unknown object on tile");
        return;
    }
    public abstract void PlayerOnTrigger(GameObject obj);
    public abstract void DogOnTrigger(GameObject obj);
}
