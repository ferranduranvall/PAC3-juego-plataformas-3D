using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpawnZombies : MonoBehaviour
{
    public GameObject enemyManager;

    public GameObject soldier1Image, soldier2Image, soldier3Image, soldier4Image, soldier5Image;

    private void Awake()
    {
        enemyManager.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (soldier1Image.activeSelf && soldier2Image.activeSelf && soldier3Image.activeSelf && soldier4Image.activeSelf && soldier5Image.activeSelf)
        {
            enemyManager.SetActive(true);
        }
    }
}
