using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public Button[] levelsButtons;

    public void OpenScene()
    {
        SceneManager.LoadScene("Level1");
    }

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < levelsButtons.Length; i++)
        {
            if (i + 2 > levelAt)
                levelsButtons[i].interactable = false;
        }
    }
    
    public void switchScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
