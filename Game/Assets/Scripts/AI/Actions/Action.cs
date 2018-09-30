using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : ScriptableObject
{
	public string ActionName;
	public abstract void DoAction(AIEntity aiEntity);
}