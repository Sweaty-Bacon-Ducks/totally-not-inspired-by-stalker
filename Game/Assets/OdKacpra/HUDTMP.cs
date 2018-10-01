using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDTMP : MonoBehaviour
{
    public PlayerReferences playerRefs;
    public Text bulletsInMagText;

    private void Start()
    {
        bulletsInMagText.text = playerRefs.GunStats.BulletsInMagazine.ToString();
    }
}
