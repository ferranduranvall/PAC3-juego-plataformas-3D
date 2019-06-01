using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoldiersMovement : MonoBehaviour
{
    Transform vehicle;               // Reference to the vehicle position.
    NavMeshAgent nav;               // Reference to the nav mesh agent.

    Animator anim;                  // Reference to the animator component.
    public AudioSource audioSoldier;       // Reference to the voice of the soldier giving you thanks.

    void Awake()
    {
        // Set up the references.
        vehicle = GameObject.FindGameObjectWithTag("Lorry").transform;
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // ... set the destination of the nav mesh agent to the vehicle safe area.
            nav.SetDestination(vehicle.position);

            // ... tell the animator the soldier is running to safe area.
            anim.SetTrigger("Running");

            // play the sound of the soldier
            audioSoldier.Play();
        }

    }    
}
