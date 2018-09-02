using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectHelper
{
    public static float Distance(GameObject left, GameObject right)
    {
        return Vector3.Distance(left.transform.position, right.transform.position);
    }
}