using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject scoreText;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject player;
    private UserData userData;

    [SerializeField] private CollisionWithObjects collisionWithObjects;
    [SerializeField] private Text highScoreText;

    private void Start()
    {
        userData = FindObjectOfType<UserData>();

        collisionWithObjects.score = userData.highScore.highScore;

        userData.LoadField();
    }
    private void Update()
    {
        if (collisionWithObjects.life == 0 && userData.highScore.highScore <= collisionWithObjects.score)
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
            player.GetComponent<Collider2D>().enabled = false;

            gameOverText.SetActive(true);
            scoreText.SetActive(true);
            restartButton.SetActive(true);

            userData.highScore.highScore = collisionWithObjects.score;

            userData.SaveField();
        }
        if(collisionWithObjects.life == 0)
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
            player.GetComponent<Collider2D>().enabled = false;
         
            gameOverText.SetActive(true);
            scoreText.SetActive(true);
            restartButton.SetActive(true);
        }

        highScoreText.text = "Your record  " + userData.highScore.highScore + "  fruit";
    }
}
