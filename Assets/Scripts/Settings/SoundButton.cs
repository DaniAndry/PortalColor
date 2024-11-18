using UnityEngine;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    public void Play()
    {
        _audio.Play();
    }
}
