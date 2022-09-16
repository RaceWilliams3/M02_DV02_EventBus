using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute();
}


public class ToggleTurbo : Command
{
    private BikeController _controller;

    public ToggleTurbo(BikeController controller)
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

    public TurnLeft(BikeController controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.Turn(BikeController.Direction.left);
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
        _controller.Turn(BikeController.Direction.right);
    }
}
