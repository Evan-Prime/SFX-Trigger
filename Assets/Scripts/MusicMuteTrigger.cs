using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMuteTrigger : MonoBehaviour
{
    public AudioSource Music;

    private void OnTriggerEnter(Collider other)
    {
        Music.Pause();
    }

    private void OnTriggerExit(Collider other)
    {
        Music.UnPause();
    }
}
