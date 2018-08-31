using System;
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

        ServiceManager.EventService.EntityClick += (Entity en) =>
        {
            DeselectAll();
            Select(en);
        };

        ServiceManager.EventService.GameObjectClick += (GameObject go) =>
        {
            DeselectAll();
        };
    }


    public void Select(Entity entity)
    {
        entity.Select();
        _SelectedEntities.Add(entity);
    }


    public void DeselectAll()
    {
        _SelectedEntities.ForEach(e => e.Deselect());
        _SelectedEntities.Clear();
    }
}