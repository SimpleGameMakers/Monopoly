using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlService : Service
{
    private List<Entity> _SelectedEntities;


    protected override void Awake()
    {
        base.Awake();
        _SelectedEntities = new List<Entity>();

        ServiceManager.EventService.EntityClick += Select;
    }


    public void Select(Entity entity)
    {
        _SelectedEntities.Clear();
        _SelectedEntities.Add(entity);
    }


    public void MoveTo(Vector3 position)
    {
        Debug.Log("MoveTo " + position);
    }

}
