using UnityEngine;


public class AudioSFX : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip gameOverAudio;
    [SerializeField] AudioClip magicMissileLaunchClip;
    [SerializeField] AudioClip takeDamageClip;

    public void PlayGameOverAudio()
    {
        audioSource.PlayOneShot(gameOverAudio);
    }
    public void PlayMissileAudio()
    {
        audioSource.PlayOneShot(magicMissileLaunchClip);
    }
    public void PlayDamageAudio()
    {
        audioSource.PlayOneShot(takeDamageClip);
    }
}
