using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject scoreCanvasPrefab;
    private int totalPoints = 0;
    private int currentPoints = 0;
    private ScoreKeeper scoreKeeper;
    private LevelMenu levelMenu;

    // Start is called before the first frame update
    void Start()
    {
        levelMenu = FindObjectOfType<LevelMenu>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddNewPoint()
    {
        if (scoreKeeper == null)
        {
            Instantiate(scoreCanvasPrefab);
            scoreKeeper = FindObjectOfType<ScoreKeeper>();
        }

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
        FindObjectOfType<AudioManager>().Play("BombSound");
        Debug.Log("Game over!");
        levelMenu.EnableFailMenu();
    }

    public void HitGoal()
    {
        if (currentPoints >= totalPoints)
        {
            FindObjectOfType<AudioManager>().Play("GoalSound");
            levelMenu.WinLevel();
        }
    }
}
