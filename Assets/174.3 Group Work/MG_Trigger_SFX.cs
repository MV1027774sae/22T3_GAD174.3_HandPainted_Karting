using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_Trigger_SFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource playSoundX;
    public AudioSource stopSoundY;

    private void OnTriggerEnter(Collider other)
    {
        playSoundX.Play();
        stopSoundY.Stop();
    }
}
