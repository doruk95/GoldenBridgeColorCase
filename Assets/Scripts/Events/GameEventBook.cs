using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
        menuName = "Golden Bridge/Events/Game Event Book",
        fileName = "_NewBookEvent",
        order = 1)]
public class GameEventBook : ScriptableObject
{
    private readonly List<GameEventBookListener> listeners = new List<GameEventBookListener>();

    public void Raise(BookTemplate value)
    {
        for (var i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised(value);
    }

    public void RegisterListener(GameEventBookListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    public void UnregisterListener(GameEventBookListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
}
