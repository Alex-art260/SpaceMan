using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private CollisionWithObjects collisionWithObjects;

    [SerializeField] private GameObject enemies;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject scoreText;
    [SerializeField] private GameObject lifeText;
    [SerializeField] private GameObject playButton;

    public void PlayButton()
    {
        enemies.SetActive(true);
        player.SetActive(true);
        scoreText.SetActive(true);
        lifeText.SetActive(true);

        playButton.SetActive(false);

        collisionWithObjects.score = 0;
        collisionWithObjects.life = 3;
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Game");
    }
}
