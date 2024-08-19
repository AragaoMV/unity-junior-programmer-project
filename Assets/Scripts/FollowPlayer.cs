using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 mainCamera = new Vector3(0, 5, -7);
    private Vector3 frontCamera = new Vector3(-0.3f, 2, 1);
    private Vector3 currentCameraOffset;
    private int cameraIndex = 0; //Index camera (0->Main, 1-> Front Camera)

    // Start is called before the first frame update
    void Start()
    {
        currentCameraOffset = mainCamera;
    }

    // Update is called once per frame at the end
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            cameraIndex = (cameraIndex + 1) % 2  //amount of cameras available;
            switch (cameraIndex)
            {
                case 0:
                    currentCameraOffset = mainCamera;           //Camera behind the player
                    break;
                case 1:
                    currentCameraOffset = frontCamera;         //Camera at the hood of the car
                    break;
            }
        }
        
        transform.position = player.transform.position + currentCameraOffset;
    }
}

