using UnityEngine;
using UnityEngine.Serialization;

public class GameAudio : MonoBehaviour
{
    public AudioSource MusicAudioSource;
    public AudioSource SoundAudioSource;
    public AudioClip StarSound;

    public bool Enabled { get; private set; } = true;

    public void ToggleSoundState()
    {
        if(Enabled)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void PlayStarSound()
    {
        if(Enabled)
            SoundAudioSource.PlayOneShot(StarSound);
    }
    
    public void Pause()
    {
        Enabled = false;
        MusicAudioSource.Pause();
    }
    
    public void Resume()
    {
        Enabled = true;
        MusicAudioSource.Play();
    }
}