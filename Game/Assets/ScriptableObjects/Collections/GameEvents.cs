using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour {

    private List<GameEventLogic> gameEvents;

    public void Find(string name)
    {

    }
}

class GameEventLogic
{
    string name;
    public GameEvent gameEvent;
    public GameEventListener gameEventListener;
}