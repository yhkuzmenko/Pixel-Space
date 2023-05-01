using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private AudioManager am;

    private void Awake()
    {
        am = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        scoreText.text = "Score: " + ScoreManager.GetScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            am.playSFX(am.collect);
            Destroy(collision.gameObject);
            ScoreManager.AddOne();
            scoreText.text = "Score: " + ScoreManager.GetScore();
        }
        if (collision.gameObject.CompareTag("Banana"))
        {
            am.playSFX(am.collect);
            Destroy(collision.gameObject);
            ScoreManager.AddTen();
            scoreText.text = "Score: " + ScoreManager.GetScore();
        }
    }
}
