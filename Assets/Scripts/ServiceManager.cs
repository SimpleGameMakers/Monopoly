using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class ServiceManager
{
    public readonly static EntityService EntityService;
    public readonly static EventService EventService;
    public readonly static ControlService ControlService;


    public static void Initialize()
    {
        /*  empty */
    }


    static ServiceManager()
    {
        EntityService = Service.Create<EntityService>();
        EventService = Service.Create<EventService>();
        ControlService = Service.Create<ControlService>();
    }
}