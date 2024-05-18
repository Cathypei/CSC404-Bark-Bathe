using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{   
    public float walkSpeed = 1.0f;
    public float runSpeed = 6.0f;
    
    
    
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        // Dog keeps walking forward by default
        transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
    }
    
    void TurnRight()
    {
        transform.Rotate(Vector3.up * 90);
    }
    
    void TurnLeft()
    {
        transform.Rotate(Vector3.up * -90);
    }
}
