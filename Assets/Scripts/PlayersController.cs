using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayersControllers : MonoBehaviour
{
    //Player's pribvate Variables
    private float speed = 15.0f;
    private float turnSpeed = 70.0f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Axis setup
        horizontalInput = Input.GetAxis("Horizontal"+ inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle left and right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }

}