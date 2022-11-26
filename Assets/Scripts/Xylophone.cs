using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xylophone : MonoBehaviour
{
    
    public AudioClip[] audioClip;
    private AudioSource audioSource;

    public Transform[] notesT;

    private void Start() {
        Notes.toneName += PlaySound;
        audioSource = GetComponent<AudioSource> ();
    }

    private void OnDestroy() {
        Notes.toneName -= PlaySound;
    }

    private void Update() {
        if (Input.GetMouseButtonUp(0)) {
            for (int i = 0; i < notesT.Length;i++) {
            notesT[i].localScale = new Vector3 (1,1,1);
        }
        }
    }

    public void PlaySound(string name) {
        switch(name) {

            case "A":
            audioSource.PlayOneShot (audioClip[0]);
            notesT[0].localScale = pos();
            break;
            case "B":
            audioSource.PlayOneShot (audioClip[1]);
            notesT[1].localScale = pos();
            break;
            case "C":
            audioSource.PlayOneShot (audioClip[2]);
             notesT[2].localScale = pos();
            break;
            case "D":
            audioSource.PlayOneShot (audioClip[3]);
             notesT[3].localScale = pos();
            break;
            case "E":
            audioSource.PlayOneShot (audioClip[4]);
             notesT[4].localScale = pos();
            break;
            case "F":
            audioSource.PlayOneShot (audioClip[5]);
            notesT[5].localScale = pos();
            break;
            case "G":
            audioSource.PlayOneShot (audioClip[6]);
            notesT[6].localScale = pos();
            break;
            case "H":
            audioSource.PlayOneShot (audioClip[7]);
            notesT[7].localScale = pos();
            break;
        }
    }

    private Vector3 pos() {
        return new Vector3 (0.95f,0.95f,0.95f);
    }


}
