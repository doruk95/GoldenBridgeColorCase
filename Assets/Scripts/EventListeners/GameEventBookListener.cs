using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventBookListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public GameEventBook Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent<BookTemplate> Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(BookTemplate value)
    {
        Response.Invoke(value);
    }
}
