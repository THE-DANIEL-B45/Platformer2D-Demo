using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioTrigger : MonoBehaviour
{
    public AudioMixerSnapshot snapshot01;
    public AudioMixerSnapshot snapshot02;

    public string tagToCompare = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag(tagToCompare))
        {
            snapshot02.TransitionTo(0.1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(tagToCompare))
        {
            snapshot01.TransitionTo(0.1f);
        }
    }
}
