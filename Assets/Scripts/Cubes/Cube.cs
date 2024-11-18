using UnityEngine;

namespace Cubes
{
    public abstract class Cube : MonoBehaviour
    {
        [SerializeField] protected GameObject ThisCenter;

        public GameObject Center => ThisCenter;
    }
}
