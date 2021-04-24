using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionWithObjects : MonoBehaviour
{
    [SerializeField] public Text scoreCount;
    [SerializeField] private Text lifeCount;

    public int score = 0;
    public int life = 3;
    private void Update()
    {
        scoreCount.text = " " + score;
        lifeCount.text = " " + life;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Fruit")
        {
            score += 1; 
        }

        if(collision.gameObject.tag == "Enemy")
        {
            life -= 1;
        }
    }
}
