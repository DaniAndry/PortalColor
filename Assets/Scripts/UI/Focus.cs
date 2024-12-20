using UnityEngine;
using UnityEngine.Events;

namespace UI
{
    public class Focus : MonoBehaviour
    {
        public event UnityAction FocusIsBack;

        public event UnityAction FocusMissing;

        private void OnApplicationFocus(bool hasFocus)
        {
            if (hasFocus)
            {
                FocusIsBack?.Invoke();
            }
            else
            {
                FocusMissing?.Invoke();
            }
        }
    }
}
