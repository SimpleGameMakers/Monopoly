using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEventHandler : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        ServiceManager.EventService.EntityClick += (Entity e) =>
        {
            e.gameObject.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log(e.name);
        };
    }

    // Update is called once per frame
    void Update()
    {

    }
}
