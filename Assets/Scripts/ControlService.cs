using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlService : Service
{
    private ActorTaskProviderControl _actorTaskProvider;
    private List<Entity> _selectedEntities;


    private void RegisterEvents()
    {
        ServiceManager.EventService.EntityClick += (data) =>
        {
            if (data.MouseButton == MouseButton.Left)
                Select(data.Target);
        };

        ServiceManager.EventService.GameObjectClick += (data) =>
        {
            if (data.MouseButton == MouseButton.Left)
                DeselectAll();
        };
    }


    public void SendToSelected(TaskProvider taskProvider)
    {
        foreach (var entity in _selectedEntities)
            entity.Process(taskProvider);
    }


    public void SendToSelected(Task task)
    {
        foreach (var entity in _selectedEntities)
            entity.Process(task);
    }


    public void SendToSelected(Command command)
    {
        foreach (var entity in _selectedEntities)
            entity.Process(command);
    }


    public void Select(Entity entity)
    {
        DeselectAll();
        _selectedEntities.Add(entity);
        entity.Select();
        SendToSelected(_actorTaskProvider);
    }


    public void DeselectAll()
    {
        SendToSelected(Command.Create<ActorCommandRemoveTaskProvider>());
        _selectedEntities.ForEach(e => e.Deselect());
        _selectedEntities.Clear();
    }


    protected override void Awake()
    {
        base.Awake();
        _actorTaskProvider = TaskProvider.Create<ActorTaskProviderControl>();
        _selectedEntities = new List<Entity>();
        RegisterEvents();
    }

}


    protected override void Awake()
    {
        base.Awake();
        _actorTaskProvider = TaskProvider.Create<ActorTaskProviderControl>();
        _selectedEntities = new List<Entity>();
        RegisterEvents();
    }

}