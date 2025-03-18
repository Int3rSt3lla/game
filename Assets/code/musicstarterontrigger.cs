using UnityEngine;

public class musicstarterontrigger : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip music;

    private void Start()
    {
       audioSource = GetComponent<AudioSource>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(music);
        
    }
}