using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : Controller
{
    public event Action<MouseButtonEventData> MouseButtonDown = delegate { };
    public event Action<MouseButtonEventData> MouseButtonUp = delegate { };



    protected override void Update()
    {
        base.Update();

        CheckMouseButtonEvent();
    }


    public void CheckMouseButtonEvent()
    {
        MouseButton[] buttons = { MouseButton.Left, MouseButton.Rigth, MouseButton.Middle };

        foreach (MouseButton btn in buttons)
        {
            // Mouse button down
            if (Input.GetMouseButtonDown((int)btn))
            {
                MouseButtonDown.Invoke(new MouseButtonEventData()
                {
                    MouseButton = btn,
                    MousePosition = Input.mousePosition,
                    ButtonDown = true
                });
            }

            // Mouse button up
            if (Input.GetMouseButtonUp((int)btn))
            {
                MouseButtonUp.Invoke(new MouseButtonEventData()
                {
                    MouseButton = btn,
                    MousePosition = Input.mousePosition,
                    ButtonDown = false
                });
            }
        }
    }


}


public enum MouseButton
{
    Left = 0,
    Rigth = 1,
    Middle = 2
}


public struct MouseButtonEventData
{
    public Vector3 MousePosition;
    public MouseButton MouseButton;
    public bool ButtonDown;

}