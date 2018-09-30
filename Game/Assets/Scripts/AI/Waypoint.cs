using System.Collections;
using UnityEngine;

public class Waypoint : MonoBehaviour, IEnumerable
{
	public Waypoint NextWaypoint;
	public Waypoint PreviousWaypoint;
    
    /// <summary>
    /// Iterates over the waypoints
    /// </summary>
    /// <returns>An enumerator.</returns>
    public IEnumerator GetEnumerator()
	{
		for (Waypoint i = this; this != i.NextWaypoint; i = i.NextWaypoint)
		{
			yield return i;
		}
	}
}