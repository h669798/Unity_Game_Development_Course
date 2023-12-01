using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip;

    public void PlaySFX()
    {
        audioSource.PlayOneShot(clip);
    }
}
