using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseFiniteStateMachine : MonoBehaviour
{
    public State CurrentState;
    public State RemainState;

	public virtual void TransitionToState(State NextState)
    {
        if (NextState != RemainState)
		{
			CurrentState = NextState;
        }
    }
}