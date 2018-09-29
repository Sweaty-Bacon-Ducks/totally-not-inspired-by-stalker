using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {

    public GameEvent FireCheckEvent;

    public abstract void FireCheck();
    public abstract void Fire();
}
