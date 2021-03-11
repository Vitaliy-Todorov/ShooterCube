using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    Button mainMenuButton;

    List<CharecterSaveData> listGmObj;

    [SerializeField]
    Button saveButton;

    [SerializeField]
    Button loadButton;

    private void Start()
    {
        listGmObj = GameObject.Find("Shared").GetComponent<MainLoad>().listGmObj;

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
        VoluntarySave.SaveGame(listGmObj);
    }

    void Load()
    {
        VoluntarySave.LoadGame(listGmObj);
    }
}
