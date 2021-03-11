using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    Button mainMenuButton;

    [SerializeField]
    List<CharecterSaveData> objectsSave;

    [SerializeField]
    Button saveButton;

    [SerializeField]
    Button loadButton;

    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);

        saveButton.onClick.AddListener(Save);

        loadButton.onClick.AddListener(Load);
    }

    void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void Save()
    {
        VoluntarySave.SaveGame(objectsSave);
    }

    void Load()
    {
        objectsSave = VoluntarySave.GetSaveGmObj();
        VoluntarySave.LoadGame(objectsSave);
    }
}
