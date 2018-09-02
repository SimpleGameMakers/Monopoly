using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActorCommandMoveTo : ActorCommand
{
    public Vector3 Target;


    public ActorCommandMoveTo Assign(Vector3 target)
    {
        Target = target;
        return this;
    }


    public override void Execute(Actor actor)
    {
        actor.MoveTo(Target);
    }
}