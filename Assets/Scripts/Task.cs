using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Task : ScriptableObject
{
    public static T Create<T>() where T : Task
    {
        return CreateInstance<T>();
    }


    protected virtual void Awake()
    {
        /* empty */
    }
}



public abstract class ActorTask : Task
{
    public abstract ActorCommand GetCommand(Actor target);


    public static ActorCommandRemoveTask RemoveTask;


    protected override void Awake()
    {
        base.Awake();

        if (RemoveTask == null)
            RemoveTask = Command.Create<ActorCommandRemoveTask>();
    }
}