using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicZone : MonoBehaviour
{
    public AudioSource audioSource;
    public float fadeTime;
    private float targetVolume;

    private void Start()
    {
        targetVolume = 0;
        audioSource.volume = 0;
    }

    private void Update()
    {
        audioSource.volume = Mathf.MoveTowards(audioSource.volume, targetVolume, (1.0f / fadeTime) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            targetVolume = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            targetVolume = 0;
    }
}
