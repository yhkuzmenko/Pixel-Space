using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private void Start()
    {
        scoreText.text = "Final score: " + ScoreManager.GetScore();
    }

    public void Quit()
    {
        Application.Quit();
    }
}