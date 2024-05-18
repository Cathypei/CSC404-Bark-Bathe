using UnityEngine;

public class finalpickupobject : MonoBehaviour
{
    public GameObject myHands; // Reference to your hands/the position where you want your object to go
    bool canpickup; // A bool to see if you can or cant pick up the item
    GameObject ObjectIwantToPickUp; // The gameobject on which you collided with
    bool hasItem; // A bool to see if you have an item in your hand

    void Start()
    {
        canpickup = false; // Setting both to false
        hasItem = false;
    }

    void Update()
    {
        if (canpickup && !hasItem && ObjectIwantToPickUp != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                BoxCollider[] bc = ObjectIwantToPickUp.GetComponents<BoxCollider>();
                foreach (BoxCollider b in bc)
                {
                    b.enabled = false;
                }
                ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = true;
                ObjectIwantToPickUp.transform.position = myHands.transform.position;
                ObjectIwantToPickUp.transform.parent = myHands.transform;
                hasItem = true;

                var itemUIPrompt = ObjectIwantToPickUp.GetComponent<ItemUIPrompt>();
                if (itemUIPrompt != null)
                {
                    itemUIPrompt.HidePrompt();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && hasItem && ObjectIwantToPickUp != null)
        {
            BoxCollider[] bc = ObjectIwantToPickUp.GetComponents<BoxCollider>();
            foreach (BoxCollider b in bc)
            {
                b.enabled = true;
            }
            ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = false;
            hasItem = false;
            ObjectIwantToPickUp.transform.parent = null;
            ObjectIwantToPickUp = null; // Reset the reference

            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("object"))
        {
            canpickup = true;
            ObjectIwantToPickUp = other.gameObject;

            var itemUIPrompt = ObjectIwantToPickUp.GetComponent<ItemUIPrompt>();

                itemUIPrompt.ShowPrompt();
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("object"))
        {
            canpickup = false;

            var itemUIPrompt = other.gameObject.GetComponent<ItemUIPrompt>(); // Use 'other.gameObject' directly
            if (itemUIPrompt != null)
            {
                itemUIPrompt.HidePrompt();
            }
        }
    }
}
