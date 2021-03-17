using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoad : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> listGmObj;

    void Start()
    {
        string filePath = PlayerPrefs.GetString("MainLoad");

        if (filePath != "")
        {
            VoluntarySave.LoadGame(listGmObj);
            PlayerPrefs.DeleteKey("MainLoad");
        }
    }

    /*public static List<CharecterSaveData> GetSaveGmObj()
    {
        return listGmObj;
    }*/
}
