using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmitter ballDataTransmitter;

    [SerializeField] private float ballMoveSpeed;

    private void Update()
    {
        SettBallMovement();
    }

    private void SettBallMovement()
    {
        transform.position += ballDataTransmitter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
