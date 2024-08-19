using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player's pribvate Variables
    private float speed = 15.0f;
    private float turnSpeed = 70.0f ;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inputing player's controlls
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);  //Vehicle moving forward 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);    //Vehicle turns
    }
}
