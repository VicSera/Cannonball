
using System;
using UnityEngine;

public class Bell : MonoBehaviour
{
    private AudioSource _audioSource;
    
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        _audioSource.Play();
    }
}
