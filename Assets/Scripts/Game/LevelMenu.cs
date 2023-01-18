using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public GameObject escapeMenu;
    public GameObject failMenu;
    public GameObject winMenu;
    private int levelNumber;
    private bool gamePaused = false;

    // Start is called before the first frame update
    void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        levelNumber = int.Parse(sceneName.Substring(5));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                gamePaused = false;
                DisableEscapeMenu();
            }
            else
            {
                gamePaused = true;
                EnableEscapeMenu();
            }
        }
    }

    private void EnableEscapeMenu()
    {
        escapeMenu.SetActive(true);
        PauseGame();
    }

    private void DisableEscapeMenu()
    {
        escapeMenu.SetActive(false);
        ResumeGame();
    }

    public void EnableFailMenu()
    {
        failMenu.SetActive(true);
        PauseGame();
    }

    private void EnableWinMenu()
    {
        winMenu.SetActive(true);
        PauseGame();
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void WinLevel()
    {
        Debug.Log("Win!");
        LevelsMenu.ActivateToLevel(levelNumber + 1);
        EnableWinMenu();
    }

    public void GoToMenu()
    {
        ResumeGame();
        SceneManager.LoadScene("Menu");
    }

    public void GoToNextLevel()
    {
        string sceneName = "Level" + (levelNumber + 1);
        int buildIndex = SceneUtility.GetBuildIndexByScenePath(sceneName);

        if (buildIndex >= 0)
        {
            ResumeGame();
            SceneManager.LoadScene(sceneName);
        }
        else
            GoToMenu();
    }

    public void RestartLevel()
    {
        ResumeGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
