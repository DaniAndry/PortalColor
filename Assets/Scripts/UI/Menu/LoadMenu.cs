using UnityEngine;
using UnityEngine.SceneManagement;
using SDK;

namespace UI
{
    public class LoadMenu : MonoBehaviour
    {
        [SerializeField] private InitializingSDK _sdk;

        private void OnEnable()
        {
            _sdk.SDKInitialized += Load;
        }

        private void Load()
        {
            SceneManager.LoadScene(1);
        }
    }
}