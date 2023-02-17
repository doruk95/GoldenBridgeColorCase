using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
        menuName = "Golden Bridge/Events/Game Event Page",
        fileName = "_NewPageEvent",
        order = 0)]
public class GameEventPage : ScriptableObject
{
    private readonly List<GameEventPageListener> listeners = new List<GameEventPageListener>();

    public void Raise(PageTemplate value)
    {
        for (var i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised(value);
    }

    public void RegisterListener(GameEventPageListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    public void UnregisterListener(GameEventPageListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
}
