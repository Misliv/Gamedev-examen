using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float Speed = 5;
    public float xMovement; 
    public float yMovement; 
    public float xEdge = 4.5f; 
    public float yEdge = 4.5f; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = (Input.GetAxis("Horizontal"));
        yMovement = (Input.GetAxis("Vertical"));
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xEdge, xEdge), Mathf.Clamp(transform.position.y, -yEdge, yEdge));
    }
    
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + xMovement / 100 * Speed, transform.position.y + yMovement / 100 * Speed);
    }
}
