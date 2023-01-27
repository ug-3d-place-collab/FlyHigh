using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public Button[] levelsButtons;

    private static int maxActiveLevel = 1;
    private static bool loadedGameStateFromRegistry = false;

    public static void ActivateToLevel(int number)
    {
        maxActiveLevel = number;
        SaveGameState();
    }

    public void OpenScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    void Start()
    {
        if (!loadedGameStateFromRegistry)
        {
            LoadGameState();
            loadedGameStateFromRegistry = true;
        }

        for (int i = 0; i < levelsButtons.Length; i++)
        {
            if (i + 1 > maxActiveLevel)
                levelsButtons[i].interactable = false;
        }
    }
    
    public void switchScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public static void LoadGameState()
    {
        maxActiveLevel = PlayerPrefs.GetInt("MaxLevel", 1);
    }

    public static void SaveGameState()
    {
        PlayerPrefs.SetInt("MaxLevel", maxActiveLevel);
        PlayerPrefs.Save();
    }

    public static void ResetGameState()
    {
        PlayerPrefs.DeleteAll();
        maxActiveLevel = 1;
    }
}
