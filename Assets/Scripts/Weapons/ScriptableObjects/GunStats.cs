using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GunStats : ScriptableObject {

    public new string name;
    public string description;
    public Sprite sprite;

    public float baseDamage;
    public float timeBetweenShots;
    //protected float shootTimer = 0;
    public float bulletSpread;
    public int bulletCount; // How many bullets leave the barrel in one shot
    public float bulletLifeTime; // some pistol and shotguns bullets will dissapear after a while
    public int magazineSize;
    //public float bulletsInMagazine;

    public float bulletSpeed;
    public float reloadTime;

    public float weight;
    public float condition;
    public int price;

    public bool sprintAllowed;

    public List<AudioClip> shootSounds;
    public AudioClip holsterSound;
    public AudioClip unholsterSound;
    public AudioClip emptySound;
    public AudioClip reloadSound;

    public AmmoClass ammoClass;
    public WeaponClass weaponClass;

    public float JammingModifier; // how condition decrease affects jamming probability
    public float basicConDecrease; // decrease in condition each shot (bad ammo can speed it up)

    //Add Scope, Silencer, GrenadeLauncher?, Firing modes, permanent/attachable addons
}

public enum WeaponClass
{
    Pistol,
    Shotgun
};