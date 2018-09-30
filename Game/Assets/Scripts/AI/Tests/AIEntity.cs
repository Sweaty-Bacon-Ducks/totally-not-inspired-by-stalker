using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(BaseFiniteStateMachine))]
public class AIEntity : Entity 
{
	public List<Waypoint> Waypoints;

	private BaseFiniteStateMachine m_StateMachine;
	public BaseFiniteStateMachine StateMachine => m_StateMachine;

	private NavMeshAgent m_Agent;
	public NavMeshAgent Agent => m_Agent;

	private void Update()
    {
		// Update state
		StateMachine.CurrentState.UpdateState(this);
    }

	public override void Die()
	{
		base.Die();
	}

	public override void TakeDamage(float dmg)
	{
		base.TakeDamage(dmg);
	}
}
