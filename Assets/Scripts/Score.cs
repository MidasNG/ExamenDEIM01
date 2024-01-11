using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    public int score;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    public void ScoreUp()
    {
        score++;
        textMesh.text = (score).ToString();
    }

    public void ScoreReset()
    {
        score = 0;
        textMesh.text = (score).ToString();
    }
}
