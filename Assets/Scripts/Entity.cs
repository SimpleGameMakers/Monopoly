using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public abstract class Entity : MonoBehaviour
{
    public event Action Click = delegate { };


    protected virtual void Awake()
    {
        ServiceManager.EventService.RegisterEvents(this);
    }


    protected void OnMouseDown()
    {
        Click.Invoke();
    }

}
