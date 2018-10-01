using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DictionaryObject : ScriptableObject {

    private Dictionary<string, GunStats> guns = new Dictionary<string, GunStats>();

    public void AddGun(GunStats gunStats)
    {
        string gunName = gunStats.name; // make unique name
        int i = 1;
        while(guns.ContainsKey(gunName))
        {
            gunName = gunStats.name + i;
            ++i;
        }

        guns.Add(gunName, gunStats);
    }
}
