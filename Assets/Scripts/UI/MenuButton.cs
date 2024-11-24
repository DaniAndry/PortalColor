using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class MenuButton : MonoBehaviour
    {
        public void LoadMenu()
        {
            SceneManager.LoadScene(1);
        }
    }
}