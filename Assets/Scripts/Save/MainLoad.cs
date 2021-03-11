using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoad : MonoBehaviour
{
    public List<CharecterSaveData> listGmObj;

    void Start()
    {
        string filePath = PlayerPrefs.GetString("MainLoad");

        if (filePath != "")
        {
            VoluntarySave.LoadGame(listGmObj);
            PlayerPrefs.DeleteKey("MainLoad");
        }
    }
}
