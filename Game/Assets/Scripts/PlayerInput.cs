using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour {

    public GameEvent OnReloadKey;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            OnReloadKey.Raise();
        }
    }
}
