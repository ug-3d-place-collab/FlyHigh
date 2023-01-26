using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollision : MonoBehaviour
{
    private LevelManager levelManager;
    private bool isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.AddNewPoint();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isHit)
        {
            FindObjectOfType<AudioManager>().Play("PointSound");
            isHit = true;
            levelManager.HitPoint();
            Destroy(gameObject);
        }
    }
}
