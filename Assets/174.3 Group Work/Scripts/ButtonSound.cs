using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    // Assign an AudioSource component and an audio clip in the Inspector.
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Update()
    {
        // Check if the button is pressed.
        if (Input.GetButtonDown("Fire1"))
        {
            // Play the audio clip.
            audioSource.PlayOneShot(audioClip);
        }
    }
}
