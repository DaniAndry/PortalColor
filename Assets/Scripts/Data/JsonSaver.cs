using UnityEngine;

namespace Data
{
    public class JsonSaver : MonoBehaviour
    {
        public void SaveData(PlayerData playerData)
        {
            string jsonData = JsonUtility.ToJson(playerData);
            string savePath = Application.persistentDataPath + "/SaveData.json";

            System.IO.File.WriteAllText(savePath, jsonData);
        }

        public PlayerData LoadData()
        {
            string savePath = Application.persistentDataPath + "/SaveData.json";

            if (System.IO.File.Exists(savePath))
            {
                string jsonData = System.IO.File.ReadAllText(savePath);
                PlayerData playerData = JsonUtility.FromJson<PlayerData>(jsonData);
                return playerData;
            }
            else
            {
                return null;
            }
        }
    }
}