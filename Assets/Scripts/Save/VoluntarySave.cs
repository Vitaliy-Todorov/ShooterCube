using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class VoluntarySave : Save
{
    public static List<CharecterSaveData> GetSaveGmObj()
    {
        return GameObject.Find("Shared").GetComponent<MainLoad>().listGmObj;
    }

    public static void SaveGame(List<CharecterSaveData> listGmObj)
    {
        string filePath = Application.persistentDataPath + "/save.gamesave";

        //Для сериализации
        BinaryFormatter bf = new BinaryFormatter();
        //Создаём поток
        FileStream fs = new FileStream(filePath, FileMode.Create);

        foreach (CharecterSaveData saveGmObj in listGmObj)
        {
            //превращем объект в string закодированный Json
            string jsonData = JsonUtility.ToJson(saveGmObj, true);

            //сериализуем и сохраняем
            bf.Serialize(fs, jsonData);
        }

        //Закрываем поток
        fs.Close();
    }

    public static void LoadGame(List<CharecterSaveData> listGmObj)
    {
        string filePath = Application.persistentDataPath + "/save.gamesave";

        if (!File.Exists(filePath))
            return;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Open);

        foreach (CharecterSaveData loadGmObj in listGmObj)
        {
            JsonUtility.FromJsonOverwrite((string) bf.Deserialize(fs), loadGmObj);
        }

        fs.Close();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
