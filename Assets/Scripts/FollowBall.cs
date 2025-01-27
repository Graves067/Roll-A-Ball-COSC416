using UnityEngine;
using UnityEngine.Rendering;

public class FollowBall : MonoBehaviour
{
    public Vector3 Camera;
    public Transform Ball;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.position + Camera;
    }
}
