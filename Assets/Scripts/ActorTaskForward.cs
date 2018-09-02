using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "SGM/Tasks/Actor/Forward")]
public class ActorTaskForward : ActorTask
{
    public GameObject Target;
    public float Distance;


    public ActorTaskForward Assign(GameObject target, float distance)
    {
        Target = target;
        Distance = distance;
        return this;
    }


    public override ActorCommand GetCommand(Actor target)
    {
        return Command.Create<ActorCommandForward>().Assign(Target, Distance);
    }
}
