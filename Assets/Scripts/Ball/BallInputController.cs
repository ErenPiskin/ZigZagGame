using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{

   [HideInInspector] public Vector3 ballDirection;
    void Start()
    {
        ballDirection = Vector3.left;
    }

   
    void Update()
    {
        HandleBallInputs();

    }

    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection()
    {
        if (ballDirection.x== -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
}
