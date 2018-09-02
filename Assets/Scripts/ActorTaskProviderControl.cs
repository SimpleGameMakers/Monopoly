using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActorTaskProviderControl : ActorTaskProvider
{
    private ActorTask PendingTask;


    public override ActorTask GetTask(Actor entity)
    {
        ActorTask tmp = PendingTask;
        PendingTask = null;

        return tmp;
    }


    private void SettingEvent()
    {
        ServiceManager.EventService.GameObjectClick += (data) => {
            if (data.MouseButton == MouseButton.Rigth)
                PendingTask = Task.Create<ActorTaskMoveTo>().Assign(data.ClickPoint);
        };
    }


    protected override void Awake()
    {
        base.Awake();
        SettingEvent();
    }
}
