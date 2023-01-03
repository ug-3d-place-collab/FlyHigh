using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailCollision : MonoBehaviour
{
    private LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        levelManager.FailGame();
    }
}
