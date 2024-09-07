using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPreFab;  // Reference to the Ball prefab
    public int ballCount = 0; // Counter for the number of balls
    public bool isBallShot = false; // Flag to track if a ball is already shot

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Check for mouse click (left button)
        if (Input.GetMouseButtonDown(0) && !isBallShot)
        {

            // Instantiate a new ball
            BallPrefab ball = Instantiate<BallPrefab>(ballPreFab);
            ball.transform.position = transform.position;
            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * UnityEngine.Random.Range(900, 1000));

            isBallShot = true; // Set flag to true indicating a ball has been shot
            ballCount++; // Increment the ball count
          



        }
        else if (!Input.GetMouseButton(0))
        {
            // Reset flag when the mouse button is not pressed
            isBallShot = false;
        }
    }
}