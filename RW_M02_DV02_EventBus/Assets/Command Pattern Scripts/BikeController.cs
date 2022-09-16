using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class ToggleTurbo : Command
    {
        private BikeController _controller;

        public ToggleTurbo (BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }

    public class TurnLeft : Command
    {
        private BikeController _controller;

        public TurnLeft (BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController.Direction.Left);
        }
    }

    public class TurnRight : Command
    {
        private BikeController _controller;

        public TurnRight(BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController.Direction.Right);
        }
    }

    public class BikeController : MonoBehaviour
    {
        public enum Direction
        {
            left = -1,
            Right = 1
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
                transform.Translate(Vector3.Left * _distance);
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
}
