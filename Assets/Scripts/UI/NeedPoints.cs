using UnityEngine;

namespace UI
{
    public class NeedPoints : MonoBehaviour
    {
        public bool TryToEnter(int numberLevel, int countPoints)
        {
            int requiredPoints = 2;
            int basePoints = 2;
            int incrementPoints = 3;
            int incrementLevel = 4;

            for (int i = 0; i < numberLevel; i++)
            {
                if (numberLevel < incrementLevel)
                {
                    requiredPoints += incrementPoints;
                }
                else
                {
                    requiredPoints += basePoints;
                }
            }

            return countPoints >= requiredPoints;
        }
    }
}
