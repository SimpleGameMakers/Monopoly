using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    public static T Create<T>(string gameObjectName) where T:Controller
    {
        return new GameObject(gameObjectName).AddComponent<T>();
    }


    #region MonoBehaviour
    protected virtual void Awake()
    {
        /* empty */
    }


    protected virtual void Update()
    {
        /* empty */
    }
    #endregion
}
