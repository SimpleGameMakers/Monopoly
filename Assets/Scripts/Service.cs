using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service : ScriptableObject
{
    public static T Create<T>() where T:Service
    {
        return CreateInstance<T>();
    }


    protected virtual void Awake()
    {
        /* empty */
    }

}