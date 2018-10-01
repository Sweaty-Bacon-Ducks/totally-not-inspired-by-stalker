using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent response;

    /// <summary>
    /// Override this to override the OnEnableLogic()
    /// </summary>
    public virtual void OnEnableLogic()
    {
        if (gameEvent != null)
            gameEvent.RegisterListener(this);
    }

    void OnEnable()
    {
        OnEnableLogic();
    }

    /// <summary>
    /// Override this to override the OnDisableLogic()
    /// </summary>
    public virtual void OnDisableLogic()
    {
        if (gameEvent != null)
            gameEvent.UnregisterListener(this);
    }

    void OnDisable()
    {
        OnDisableLogic();
    }

    public virtual void OnEventRaised()
    {
        response.Invoke();
    }
}
