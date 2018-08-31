using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventService : Service
{
    public event Action<Entity> EntityClick = delegate { };


    public void RegisterEvents(Entity entity)
    {
        entity.Click += delegate { EntityClick.Invoke(entity); };
    }

}