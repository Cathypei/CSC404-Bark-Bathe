using UnityEngine;

public class ItemUIPrompt : MonoBehaviour
{
    public GameObject promptUI; // Reference to the UI Text GameObject

    void Start()
    {
        if (promptUI != null)
        {
            promptUI.SetActive(false); // Hide the prompt initially
        }
    }

    public void ShowPrompt()
    {
        if (promptUI != null)
        {
            promptUI.SetActive(true); // Show the prompt
        }
    }

    public void HidePrompt()
    {
        if (promptUI != null)
        {
            promptUI.SetActive(false); // Hide the prompt
        }
    }
}
