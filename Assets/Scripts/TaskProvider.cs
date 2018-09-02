using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class TaskProvider : ScriptableObject
{
    public static T Create<T>() where T : TaskProvider
    {
        return CreateInstance<T>();
    }


    protected virtual void Awake()
    {
        /* empty */
    }
}


public abstract class ActorTaskProvider : TaskProvider
{
    public abstract ActorTask GetTask(Actor entity);
}