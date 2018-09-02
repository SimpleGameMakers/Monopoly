using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Command : ScriptableObject
{
    public static T Create<T>() where T : Command
    {
        return CreateInstance<T>();
    }
}


public abstract class ActorCommand : Command
{
    public abstract void Execute(Actor target);
}