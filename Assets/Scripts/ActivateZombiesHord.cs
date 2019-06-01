using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateZombiesHord : MonoBehaviour
{
    public GameObject zombiesHord;


    private void Awake()
    {
        zombiesHord.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            zombiesHord.SetActive(true);
        }
    }
}