using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider))]
public abstract class Entity : MonoBehaviour
{
    public static T Create<T>(string name) where T : Entity
    {
        GameObject gameObject = new GameObject(name);
        return gameObject.AddComponent<T>();
    }

    #region ProcessMessage
    public virtual void Process(TaskProvider taskProvider)
    {
        /* empty */
    }


    public virtual void Process(Task task)
    {
        /* empty */
    }


    public virtual void Process(Command command)
    {
        /* empty */
    }
    #endregion

    #region Select/Deselect
    private bool _isSelected;


    public bool IsSelected()
    {
        return _isSelected;
    }


    public virtual void Select()
    {
        _isSelected = true;
    }


    public virtual void Deselect()
    {
        _isSelected = false;
    }
    #endregion

    #region MonoBehaviour
    protected virtual void OnValidate()
    {
        /* empty */
    }


    protected virtual void Start()
    {
        _isSelected = false;
    }


    protected virtual void Update()
    {
        /* empty */
    }
    #endregion
}
