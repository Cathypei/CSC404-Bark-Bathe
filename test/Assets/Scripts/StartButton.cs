using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    MasterSceneManager managerComp;
    // Start is called before the first frame update
    void Start()
    {
        GameObject sceneManager = GameObject.FindGameObjectWithTag("GameController");
        if (sceneManager != null)
        {
            managerComp = sceneManager.GetComponent<MasterSceneManager>();
        }
        else {
            Debug.Log("Fail to locate scene manager");
        }
        if (managerComp != null)
        {
            Button button = GetComponent<Button>();
            // Add a listener to the button click event
            button.onClick.AddListener(InvokeSceneManager);
        }
        else {
            Debug.Log("Fail to find scene manager script");
        }
    }

    void InvokeSceneManager() {
        managerComp.LoadGameScene();
    }
}
