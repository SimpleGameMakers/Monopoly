using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActorTaskMoveTo : ActorTask
{
    public Vector3 Target;


    public ActorTaskMoveTo Assign(Vector3 target)
    {
        Target = target;
        return this;
    }


    private bool _moveStarted = false;
    public override ActorCommand GetCommand(Actor actor)
    {
        if (!_moveStarted || !actor.IsMoveCompleted())
        {
            _moveStarted = true;
            return Command.Create<ActorCommandMoveTo>().Assign(Target);
        }

        return RemoveTask;
    }
}