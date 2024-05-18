using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision dog)
    {
        if (dog.gameObject.CompareTag("Dog"))
        {
            DogState dogState = dog.gameObject.GetComponent<DogState>();

            if (dogState.CleanState == false)
            {
                Destroy(dog.gameObject);
                SceneManager.LoadScene("GameOverScene"); 
            }else{
                Destroy(dog.gameObject);
                SceneManager.LoadScene("YouWinScene"); 
            }
        }
    }
}
