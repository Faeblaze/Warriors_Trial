﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCam : MonoBehaviour {

    public Transform playerCam, character, centerpoint;
    private float mouseX, mouseY;
    public float mouseSensitivity = 10f;
    public float mouseYPosition = 1.5f;

    private float moveFB, moveLF;
    public float moveSpeed = 2f;

    private float zoom;
    public float zoomSpeed = 2;

    public float zoomMin = -2;
    public float zoomMax = -10;

    public float rotationSpeed = 5f;
    
	// Use this for initialization
	void Start ()
    {
        zoom = -3;	
	}

    // Update is called once per frame
    void Update()
    {
        zoom += Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

        if (zoom > zoomMin)
            zoom = zoomMin;

        if (zoom < zoomMax)
            zoom = zoomMax;

        playerCam.transform.localPosition = new Vector3(0, 0, zoom);

        if (Input.GetMouseButton(1))
        {
            mouseX += Input.GetAxis("Mouse X");
            mouseY -= Input.GetAxis("Mouse Y");
        }

        mouseY = Mathf.Clamp(mouseY, -60f, 60f);
        playerCam.LookAt(centerpoint);
        centerpoint.localRotation = Quaternion.Euler(mouseY, mouseX, 0);

        moveFB = Input.GetAxis("Vertical") * moveSpeed;
        moveLF = Input.GetAxis("Horizontal") * moveSpeed;

        Vector3 movement = new Vector3(moveLF, 0, moveFB);
        movement = character.rotation * movement;

        character.GetComponent<CharacterController>().Move(movement * Time.deltaTime);
        centerpoint.position = new Vector3(character.position.x, character.position.y + mouseYPosition, character.position.z);

        if (Input.GetAxis("Vertical") > 0 | Input.GetAxis ("Vertical") < 0)
        {
            Quaternion turnAngle = Quaternion.Euler (0, centerpoint.eulerAngles.y, 0);

            character.rotation = Quaternion.Slerp(character.rotation, turnAngle, Time.deltaTime * rotationSpeed);
        }
    }
    
}
