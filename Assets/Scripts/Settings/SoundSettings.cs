using UnityEngine;
using UnityEngine.UI;

namespace Settings
{
    public class SoundSettings : MonoBehaviour
    {
        [SerializeField] private AudioSource _music;
        [SerializeField] private AudioSource _sound;
        [SerializeField] private AudioSource _finish;

        [SerializeField] private Image _soundImage;
        [SerializeField] private Image _musicImage;
        [SerializeField] private Image _soundImageStop;
        [SerializeField] private Image _musicImageStop;

        private bool _isMusic;
        private bool _isSound;

        private const float _fullVolume = 100f;

        private void Start()
        {
            _music.volume = PlayerPrefs.GetFloat("MusicVolume", _fullVolume);
            _sound.volume = PlayerPrefs.GetFloat("SoundVolume", _fullVolume);
            _finish.volume = _sound.volume;

            _isMusic = _music.volume > 0;
            _isSound = _sound.volume > 0;

            ChangeImage(_isMusic, _musicImage, _musicImageStop);
            ChangeImage(_isSound, _soundImage, _soundImageStop);
        }

        public void SwitchVolumeMusic()
        {
            _isMusic = ToggleVolume(ref _music, "MusicVolume");
            ChangeImage(_isMusic, _musicImage, _musicImageStop);
        }

        public void SwitchVolumeSound()
        {
            _isSound = ToggleVolume(ref _sound, "SoundVolume");
            _finish.volume = _sound.volume;
            ChangeImage(_isSound, _soundImage, _soundImageStop);
        }

        private bool ToggleVolume(ref AudioSource audioSource, string playerPrefKey)
        {
            if (audioSource.volume == 0)
            {
                PlayerPrefs.SetFloat(playerPrefKey, _fullVolume);
            }
            else
            {
                PlayerPrefs.SetFloat(playerPrefKey, 0);
            }
            audioSource.volume = PlayerPrefs.GetFloat(playerPrefKey);
            return audioSource.volume > 0;
        }

        private void ChangeImage(bool isActive, Image activeImage, Image stopImage)
        {
            activeImage.gameObject.SetActive(isActive);
            stopImage.gameObject.SetActive(!isActive);
        }
    }
}
