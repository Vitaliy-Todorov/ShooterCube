using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public static class VoluntarySave
{
    static string filePath = Application.persistentDataPath + "/save.gamesave";

    public static void SaveGame(List<GameObject> listGmObj)
    {
        //��� ������������
        BinaryFormatter bf = new BinaryFormatter();
        //������ �����
        FileStream fs = new FileStream(filePath, FileMode.Create);

        foreach (GameObject saveGmObj in listGmObj)
        {
            saveGmObj.GetComponent<Motion>().SavePosition();
            DataStorageShootingCube saveDate = saveGmObj.GetComponent<StorageReferenceShootingCube>().data;
            //��������� ������ � string �������������� Json
            string jsonData = JsonUtility.ToJson(saveDate, true);

            //����������� � ���������
            bf.Serialize(fs, jsonData);
        }

        //��������� �����
        fs.Close();
    }

    public static void LoadGame(List<GameObject> listGmObj)
    {
        if (!File.Exists(filePath))
            return;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Open);

        foreach (GameObject loadGmObj in listGmObj)
        {
            DataStorageShootingCube loadData = loadGmObj.GetComponent<StorageReferenceShootingCube>().data;
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(fs), loadData);

            loadGmObj.GetComponent<Motion>().LoadPosition();
        }

        fs.Close();

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
