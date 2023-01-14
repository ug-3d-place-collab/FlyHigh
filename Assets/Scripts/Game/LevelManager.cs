using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int totalPoints = 0;
    private int currentPoints = 0;
    private ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void AddNewPoint()
    {
        totalPoints++;
        scoreKeeper.SetScore(currentPoints, totalPoints);
        Debug.LogFormat("Initialized {0} points", totalPoints);
    }

    public void HitPoint()
    {
        currentPoints++;
        scoreKeeper.SetScore(currentPoints, totalPoints);
        Debug.LogFormat("Found {0}/{1} points", currentPoints, totalPoints);
    }

    public void FailGame()
    {
        Debug.Log("Game over!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HitGoal()
    {
        if (currentPoints >= totalPoints)
        {
            Debug.Log("Win!");
            string sceneName = SceneManager.GetActiveScene().name;
            int sceneNumber = int.Parse(sceneName.Substring(5));
            sceneNumber++;
            LevelsMenu.ActivateToLevel(sceneNumber);
            sceneName = "Level" + sceneNumber;
            SceneManager.LoadScene(sceneName);
        }
    }
}
