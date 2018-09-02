using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorCommandRemoveTask : ActorCommand
{
    public override void Execute(Actor actor)
    {
        actor.RemoveTask();
    }
}
