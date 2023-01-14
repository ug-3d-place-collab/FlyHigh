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
        textMeshPro = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        if (textMeshPro == null)
            Debug.Log("Text not found");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetScore(int currentPoints, int maxPoints)
    {
        if (textMeshPro != null)
            textMeshPro.SetText(string.Format("Punkty {0}/{1}", currentPoints, maxPoints));
    }
}
