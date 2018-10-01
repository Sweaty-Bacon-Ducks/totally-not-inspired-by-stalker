using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreation : MonoBehaviour {

    public DictionaryObject allGuns;

	public GunStats CreateGun(GunStats gun)
    {
        GunStats gunStats = ScriptableObject.CreateInstance<GunStats>();
        gunStats.PasteStats(gun);
        allGuns.AddGun(gunStats);

        return gunStats;
    }
}
