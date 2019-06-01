using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoldiersInSafeArea : MonoBehaviour
{
    public GameObject soldier1, soldier2, soldier3, soldier4, soldier5;
    public GameObject soldier1Image, soldier2Image, soldier3Image, soldier4Image, soldier5Image;

    public GameObject player;
    

    public AudioSource safeAreaSound;


    void Awake()
    {
        soldier1.SetActive(false);
        soldier2.SetActive(false);
        soldier3.SetActive(false);
        soldier4.SetActive(false);
        soldier5.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Soldier")
        {
            soldier1.SetActive(true);
            soldier1Image.SetActive(true);
            safeAreaSound.Play();
        }

        if (other.tag == "Soldier2")
        {
            soldier2.SetActive(true);
            soldier2Image.SetActive(true);
            safeAreaSound.Play();

        }

        if (other.tag == "Soldier3")
        {
            soldier3.SetActive(true);
            soldier3Image.SetActive(true);
            safeAreaSound.Play();

        }

        if (other.tag == "Soldier4")
        {
            soldier4.SetActive(true);
            soldier4Image.SetActive(true);
            safeAreaSound.Play();

        }

        if (other.tag == "Soldier5")
        {
            soldier5.SetActive(true);
            soldier5Image.SetActive(true);
            safeAreaSound.Play();

        }

        if (other.tag == "Player" && soldier1Image.activeSelf && soldier2Image.activeSelf && soldier3Image.activeSelf && soldier4Image.activeSelf && soldier5Image.activeSelf)
        {
            player.SetActive(true);
            SceneManager.LoadScene("EndGame");
        }


    }
}
