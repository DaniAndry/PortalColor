using Agava.WebUtility;
using UnityEngine;
using PlayerSpace;

namespace UI
{
    public class Education : MonoBehaviour
    {
        [SerializeField] private GameObject _horizontalSlider;
        [SerializeField] private GameObject _verticalSlider;
        [SerializeField] private GameObject _educationPanel;
        [SerializeField] private GameObject _horizontalButtons;
        [SerializeField] private GameObject _verticalButtons;
        [SerializeField] private PlayerMover _playerMover;

        private bool _isEducationEnabled = true;
        private bool _isHorizontalMoved = false;
        private bool _isMobileGame;

        private void Start()
        {
            _educationPanel.SetActive(true);

            if (Device.IsMobile)
            {
                _isMobileGame = true;
                _horizontalSlider.SetActive(true);
            }
            else
            {
                _isMobileGame = false;
                _horizontalButtons.SetActive(true);
            }

            _playerMover.Moved += OnPlayerMove;
        }

        private void OnPlayerMove()
        {
            if (_isEducationEnabled)
            {
                if (!_isHorizontalMoved)
                {
                    HandleHorizontalMove();
                }
                else
                {
                    HandleVerticalMove();
                }
            }
        }

        private void HandleHorizontalMove()
        {
            _isHorizontalMoved = true;
            ToggleUI(_isMobileGame ? _horizontalSlider : _horizontalButtons,
                     _isMobileGame ? _verticalSlider : _verticalButtons);
        }

        private void HandleVerticalMove()
        {
            ToggleUI(_isMobileGame ? _verticalSlider : _verticalButtons, null);
            _educationPanel.SetActive(false);
            _isEducationEnabled = false;
        }

        private void ToggleUI(GameObject hideObject, GameObject showObject)
        {
            hideObject.SetActive(false);
            if (showObject != null)
                showObject.SetActive(true);
        }
    }
}