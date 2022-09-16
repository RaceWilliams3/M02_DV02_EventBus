using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BikeController : MonoBehaviour
{
    public enum Direction
    {
        left = -1,
        right = 1
    }

    private bool _isTurboOn;
    private float _distance = 1.0f;

    public void ToggleTurbo()
    {
        _isTurboOn = !_isTurboOn;
        Debug.Log("Turbo Active: " + _isTurboOn.ToString());
    }

    public void Turn(Direction direction)
    {
        if (direction == Direction.left)
        {
            transform.Translate(Vector3.left * _distance);
        }
        if (direction == Direction.right)
        {
            transform.Translate(Vector3.right * _distance);
        }
    }

    public void ResetPosition()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

}

