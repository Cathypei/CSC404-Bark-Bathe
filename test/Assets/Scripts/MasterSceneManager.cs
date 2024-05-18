using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/** Defines all scene management in the game. The script is attached to an immortal object that presents in all scenes.
 * 
 */
public class MasterSceneManager : MonoBehaviour
{
    private static MasterSceneManager instance;
    public string gamescene = "MainScene";

    private void Awake()
    {
        // Ensure there's only one instance
        if (instance == null)
        {
            instance = this;
            // Make this object immortal during scene switching
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destroy duplicate instances
            Destroy(gameObject);
        }
    }

    private void LoadOpeningScene() { 
    
    }
    private void LoadTitleScene() { 
    
    }

    public void LoadGameScene() {
        Debug.Log("Scene Manager: Start game");
        SceneManager.LoadScene("MainScene");
    }

}
