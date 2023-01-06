using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public Button[] levelsButtons;

    private static int maxActiveLevel = 1;

    public static void ActivateToLevel(int number)
    {
        maxActiveLevel = number;
    }

    public void OpenScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < levelsButtons.Length; i++)
        {
            if (i + 2 > maxActiveLevel + 1)
                levelsButtons[i].interactable = false;
        }
    }
    
    public void switchScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
