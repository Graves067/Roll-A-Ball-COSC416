using System;
using UnityEngine;



public class BallController : MonoBehaviour
{
    [SerializeField] private Boolean Grounded = true;
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
            {
            inputVector += Vector3.up; 
            }
        
        if (Input.GetKey(KeyCode.S))
         {
            inputVector += Vector3.down;
         }
        
         if (Input.GetKey(KeyCode.D))
          {
         inputVector += Vector3.right;
          }
        
         if (Input.GetKey(KeyCode.A))
          {
          inputVector += Vector3.left;
          }

        Vector3 inputXZPlane = new(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

    }
}
