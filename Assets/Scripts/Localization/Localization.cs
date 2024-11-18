using Lean.Localization;
using UnityEngine;

namespace Localization
{
    public class Localization : MonoBehaviour
    {
        [SerializeField] private LeanLocalization _leanLocalization;
        private string _language;

        private void Start()
        {
            _language = PlayerPrefs.GetString("_currentLanguage");
            SelectLocalization(_language);
        }

        private void Select()
        {
            _language = PlayerPrefs.GetString("_currentLanguage");
            SelectLocalization(_language);
        }

        private void SelectLocalization(string language)
        {
            switch (language)
            {
                case "ru":
                    LoadLocalizationRu();
                    break;
                case "en":
                    LoadLocalizationEn();
                    break;
                case "tr":
                    LoadLocalizationTr();
                    break;
            }
        }

        private void LoadLocalizationRu()
        {
            _leanLocalization.SetCurrentLanguage("Russian");
        }

        private void LoadLocalizationEn()
        {
            _leanLocalization.SetCurrentLanguage("English");
        }

        private void LoadLocalizationTr()
        {
            _leanLocalization.SetCurrentLanguage("Turkish");
        }
    }
}