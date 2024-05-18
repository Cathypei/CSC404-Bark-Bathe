using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogState : MonoBehaviour
{
    // A whole pizza has 8 slices
    public bool CleanState;
    
    // Start is called before the first frame update
    void Start()
    {
        CleanState = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CleanStateChange(){
        CleanState = true;
    }
    void GameOver()
    {
        SceneManager.LoadScene("GameOverScene"); 
    }
}
