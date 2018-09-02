using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActorCommandForward : ActorCommand
{
    public GameObject Target;
    public float Distance;


    public ActorCommandForward Assign(GameObject target, float distance)
    {
        Target = target;
        Distance = distance;
        return this;
    }


    public override void Execute(Actor actor)
    {
        actor.MoveTo(Target.transform.position, Distance);
    }
}