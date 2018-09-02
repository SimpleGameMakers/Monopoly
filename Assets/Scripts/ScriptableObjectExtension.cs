using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScriptableObjectExtension
{
    public static T ScriptClone<T>(this T @object) where T : ScriptableObject
    {
        string oldName = @object.name;

        T clone = Object.Instantiate(@object);
        clone.name = oldName;

        return clone;
    }
}