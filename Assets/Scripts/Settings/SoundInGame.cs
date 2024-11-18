using UnityEngine;
using SDK;
using UI;

namespace Settings
{
    public class SoundInGame : MonoBehaviour
    {
        [SerializeField] private Focus _focus;
        [SerializeField] private Ad _ad;

        private void Start()
        {
            _focus.FocusIsBack += EnableFocus;
            _focus.FocusMissing += DisableFocus;
        }

        private void OnDisable()
        {
            _focus.FocusIsBack -= EnableFocus;
            _focus.FocusMissing -= DisableFocus;
        }

        public void StopSounds()
        {
            AudioListener.pause = true;
            AudioListener.volume = 0f;
        }

        public void PlaySounds()
        {
            AudioListener.pause = false;
            AudioListener.volume = 1f;
        }

        private void EnableFocus()
        {
            if (!_ad.IsRun)
            {
                PlaySounds();
            }
        }

        private void DisableFocus()
        {
            StopSounds();
        }
    }
}