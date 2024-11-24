using TMPro;
using UnityEngine;

namespace Data
{
    public class Points : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textCount;

        private PlayerData _playerData;
        private JsonSaver _jsonSaver;

        private int _count;
        private int _levels = 21;
        private int _points;

        private void Awake()
        {
            _playerData = GetComponent<PlayerData>();
            _jsonSaver = GetComponent<JsonSaver>();
            Calculate();
        }

        public int Calculate()
        {
            _count = 0;

            for (int i = 0; i < _levels; i++)
            {
                _count += PlayerPrefs.GetInt("PointsLevel" + i, 0);
                _points += PlayerPrefs.GetInt("ScoreCount" + i, 0);
            }

            PlayerPrefs.SetInt("PlayerPoints", _count);
            PlayerPrefs.SetInt("ScoreCount", _points);
            _textCount.text = _count.ToString();

            if (_count > 0 && _points > 0)
            {
                _playerData = _playerData.SetPlayerData(_count, _points);

                _jsonSaver.SaveData(_playerData);
            }

            return _count;
        }
    }
}