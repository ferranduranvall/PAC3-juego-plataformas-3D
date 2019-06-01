using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAmmo : MonoBehaviour
{
    public GameObject ammoWeaponPack;
    public AudioSource getAmmoAudio;

    public int currentAmmo;
    public Text countAmmo;

    public GameObject Weapon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ammoWeaponPack.SetActive(false);
            getAmmoAudio.Play();

            //GameObject.Find("gun").GetComponent<ShootGun>().currentAmmo = 10;
            Weapon.GetComponent<PlayerShooting>().currentAmmo = 100;
            //currentAmmo = 10;
            countAmmo.text = currentAmmo.ToString();
        }
       
    }
}
