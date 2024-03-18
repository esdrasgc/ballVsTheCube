using UnityEngine;


// O código abaixo foi retirado do video:
// https://www.youtube.com/watch?v=N8whM1GjH4w&ab_channel=RehopeGames
public class AudioManager : MonoBehaviour
{

    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    public AudioClip collectableSound;

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayCollectableSound()
    {
        sfxSource.clip = collectableSound;
        sfxSource.Play();
    }
}
