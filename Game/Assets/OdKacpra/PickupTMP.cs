using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTMP : MonoBehaviour {

    public GameObject ItemPrefab;
    public GunStats GunStats;

    public void OnTriggerEnter(Collider collision)
    {
        ItemPrefab = Instantiate(ItemPrefab, collision.transform.Find("EquippedWeapon"));
        //ItemPrefab.transform.SetAsFirstSibling();
        //ItemPrefab.GetComponent<Gun>().GunStats = GunStats;
        ItemPrefab.GetComponent<Gun>().ChangeGunStats(GunStats);
        Destroy(gameObject);
    }
}
