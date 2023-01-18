using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetScore(int currentPoints, int maxPoints)
    {
        if (textMeshPro == null)
        {
            textMeshPro = gameObject.GetComponentInChildren<TextMeshProUGUI>();
            if (textMeshPro == null)
                Debug.Log("Text not found");
        }

        textMeshPro.SetText(string.Format("Punkty {0}/{1}", currentPoints, maxPoints));
    }
}
