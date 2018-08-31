using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestActor : Actor
{
    public override void Select()
    {
        base.Select();
        GetComponent<Renderer>().material.color = Color.red;
    }


    public override void Deselect()
    {
        base.Deselect();
        GetComponent<Renderer>().material.color = Color.white;
    }

}
