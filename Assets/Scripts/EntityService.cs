using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EntityService : Service
{
    public T Create<T>(string name) where T : Entity
    {
        GameObject gameObject = new GameObject(name);
        return gameObject.AddComponent<T>();
    }


    public GameObject CreateMarker(string name)
    {
        return new GameObject(name);
    }
}