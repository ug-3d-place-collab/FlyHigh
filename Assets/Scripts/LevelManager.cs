using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int totalPoints = 0;
    private int currentPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddNewPoint()
    {
        totalPoints++;
        Debug.LogFormat("Initialized {0} points", totalPoints);
    }

    public void HitPoint()
    {
        currentPoints++;
        Debug.LogFormat("Found {0}/{1} points", currentPoints, totalPoints);
    }

    public void FailGame()
    {
        Debug.Log("Game over!");
    }

    public void HitGoal()
    {
        Debug.Log("Win!");
    }
}
