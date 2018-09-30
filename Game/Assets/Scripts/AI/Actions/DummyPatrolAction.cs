using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A simple patrol action.
/// </summary>
[CreateAssetMenu(menuName ="AI/Actions/DummyPatrolAction")]
public class DummyPatrolAction: Action
{
	public override void DoAction(AIEntity aiEntity)
	{
		var Waypoints = aiEntity.Waypoints;
		if(Waypoints.Count > 0)
		{
			Vector3 currentPosition = aiEntity.transform.position;
			Transform closestWaypoint = FindClosestWaypoint(currentPosition,
			                                                Waypoints);
			Vector3 closestWaypointPosition = closestWaypoint.position;
			aiEntity.Agent.Move(closestWaypointPosition);
            
		}    
	}
	protected virtual Transform FindClosestWaypoint(Vector3 currentPosition, 
	                                                List<Waypoint> waypoints)
    {
		Waypoint result = null;
		float min_distance = int.MaxValue;
        foreach (Waypoint waypoint in waypoints)
		{
			Vector3 waypointPosition = waypoint.transform.position;
			float distance = (currentPosition - waypointPosition).magnitude;
			if (min_distance < distance)
			{
				result = waypoint;
				min_distance = distance;
			}
		}
		return result.transform;
	}
}