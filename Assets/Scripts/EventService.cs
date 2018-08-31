using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventService : Service
{
    public event Action<GameObject> GameObjectClick = delegate { };
    public event Action<Entity> EntityClick = delegate { };


    protected override void Awake()
    {
        base.Awake();

        EventController eventController = Controller.Create<EventController>("[EVENT CONTROLLER]");
        SettingEventController(eventController);

        DontDestroyOnLoad(eventController.gameObject);
    }


    private void SettingEventController(EventController events)
    {
        events.MouseButtonUp += (MouseData) =>
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(MouseData.MousePosition);
            Physics.Raycast(ray, out hit);

            if (hit.collider != null)
            {
                GameObject gameObject = hit.collider.gameObject;
                Entity entity = gameObject.GetComponent<Entity>();

                if (entity != null)
                    EntityClick.Invoke(entity);

                else
                    GameObjectClick.Invoke(gameObject);
            }
        };
    }
    
}