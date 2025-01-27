using System;
using UnityEngine;



public class BallController : MonoBehaviour
{
    [SerializeField] private Boolean Grounded = true;
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float jumpForce = 2.0f;

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
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Grounded = false;
        }

        Vector3 inputXZPlane = new(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Grounded = true;
        }
    }
}
