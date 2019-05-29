using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFXScr : MonoBehaviour {

    // для воспроизведения эффектов

    AudioSource audio;
    public AudioClip audioClip;

	void Start () {
        audio = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.PlayOneShot(audioClip);
    }

    

}
