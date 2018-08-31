using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceManager
{
    public readonly static EventService EventService;
    public readonly static ControlService ControlService;


    static ServiceManager()
    {
        EventService = Service.Create<EventService>();
        ControlService = Service.Create<ControlService>();
    }
}