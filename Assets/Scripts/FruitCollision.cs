using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollision : MonoBehaviour
{
    [SerializeField] private InstantiateFruit instantiateFruit;
    private void Update()
    {
       if(instantiateFruit.show == true)
        {
            gameObject.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
