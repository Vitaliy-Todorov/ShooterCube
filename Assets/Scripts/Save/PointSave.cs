using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointSave : Save
{
    public static void SaveGame(List<CharecterSaveData> listGmObj)
    {
        foreach (CharecterSaveData saveGmObj in listGmObj)
        {
            string key = saveGmObj.name;

            string jsonData = JsonUtility.ToJson(saveGmObj, true);
            PlayerPrefs.SetString(key, jsonData);
            PlayerPrefs.Save();
        }
    }

    public static void LoadGame(List<CharecterSaveData> listGmObj)
    {
        foreach (CharecterSaveData loadGmObj in listGmObj)
        {
            string key = loadGmObj.name;

            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(key), loadGmObj);
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
