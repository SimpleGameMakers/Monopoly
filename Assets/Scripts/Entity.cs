using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[RequireComponent(typeof(Collider))]
public abstract class Entity : MonoBehaviour
{
    public virtual void Select()
    {
        /* empty */
    }


    public virtual void Deselect()
    {
        /* empty */
    }


    protected virtual void Awake()
    {
        /* empty */
    }


    protected virtual void Start()
    { 
        /* empty */
    }


    protected virtual void Update()
    {
        /* empty */
    }

}
