using System;
using System.Collections.Generic;

using UnityEngine;

[CreateAssetMenu(menuName = "AI/State")]
public class State : ScriptableObject
{
	public string Name;
	public List<Action> Actions;
	public List<Transition> Transitions;

	public void UpdateState(AIEntity aiEntity)
	{
        // Execute all actions 
        try
		{
			if (Actions.Count > 0)
            {
                foreach (var action in Actions)
                {
                    action.DoAction(aiEntity);
                }
            }
		}
		catch (NullReferenceException){  }

		//Check for transitions
		try
		{
			if (Actions.Count > 0)
			{
				BaseFiniteStateMachine fsa = aiEntity.StateMachine;
				foreach (var transition in Transitions)
				{
					bool decisionResult = transition.decision.DoDecision(aiEntity);

					if (decisionResult)
					{
						fsa.TransitionToState(transition.trueState);
					}
					else
					{
						fsa.TransitionToState(transition.falseState);
					}
				}
			}
		}
		catch (NullReferenceException) { }
	}   
}