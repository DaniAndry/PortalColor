using UnityEngine;

namespace PlayerSpace
{
    public class PlayerAnimations : MonoBehaviour
    {
        [SerializeField] private PlayerMover _player;

        private static int Idle = Animator.StringToHash("Idle");
        private static int Run = Animator.StringToHash("Run");

        private Animator _playerAnimator;

        private void Start()
        {
            _playerAnimator = GetComponent<Animator>();
            _playerAnimator.Play(Idle);
        }

        private void OnEnable()
        {
            _player.Moved += OnPlayerMoved;
            _player.Stoped += OnPlayerStop;
        }

        private void OnDisable()
        {
            _player.Moved -= OnPlayerMoved;
            _player.Stoped -= OnPlayerStop;
        }

        private void OnPlayerMoved()
        {
            _playerAnimator.Play(Run);
        }

        private void OnPlayerStop()
        {
            _playerAnimator.Play(Idle);
        }
    }
}
