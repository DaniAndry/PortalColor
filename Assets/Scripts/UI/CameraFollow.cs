using DG.Tweening;
using UnityEngine;

namespace UI
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        [SerializeField] private float _smoothDuration = 0.5f;

        [SerializeField] private Vector3 _offset;

        private void LateUpdate()
        {
            if (_target != null)
            {
                Vector3 desiredPosition = _target.position + _offset;
                transform.DOMove(desiredPosition, _smoothDuration);
            }
        }
    }
}