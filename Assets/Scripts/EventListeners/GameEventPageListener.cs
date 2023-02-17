using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventPageListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public GameEventPage Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent<PageTemplate> Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(PageTemplate value)
    {
        Response.Invoke(value);
    }
}
