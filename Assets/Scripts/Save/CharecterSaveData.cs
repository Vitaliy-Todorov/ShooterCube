using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nwe Charecter Save Data", menuName = "Charecter/Data", order = 1)]
public class CharecterSaveData : ScriptableObject
{
    [Header("Stats")]

    [SerializeField]
    Vector3 position;

    [SerializeField]
    float currentHealth;

    [Header("Save Data")]
    string key;

    public float CurrentHealth
    {
        set { currentHealth = value; }
        get { return currentHealth; }
    }

    private void OnEnable()
    {
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(key), this);
    }

    private void OnDisable()
    {
        if (key == "")
            key = name;

        string jsonData = JsonUtility.ToJson(this, true);
        PlayerPrefs.SetString(key, jsonData);
        PlayerPrefs.Save();
    }
}
