using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicTrigger : MonoBehaviour
{
    public AudioSource Magic;

    private void OnTriggerEnter(Collider other)
    {
        Magic.Play();
    }
}
