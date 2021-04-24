using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float screenTop;
    public float screenButtom;
    public float screenRight;
    public float screenLeft;
    public float speedMove; 
    public float strafeTime; 
    public float repeatTime; 

    void Start()
    {
        if (repeatTime > strafeTime)
        {
            InvokeRepeating("Strafe", 0.0f, repeatTime);
        }
    }

    private void Strafe()
    {
        StartCoroutine(Up());
        StartCoroutine(Right());
    }

    private void Update()
    {
        Vector2 newPos = transform.position;

        if (transform.position.y > screenTop)
        {
            newPos.y = screenButtom;
        }
        if (transform.position.y < screenButtom)
        {
            newPos.y = screenTop;
        }
        if (transform.position.x > screenRight)
        {
            newPos.x = screenLeft;
        }
        if (transform.position.x < screenLeft)
        {
            newPos.x = screenRight;
        }
        transform.position = newPos;
    }

    IEnumerator Up()
    {
        float elapsedTime = 0.0f;

        int direction = Random.Range(0, 2) == 0 ? -1 : 1;

        while (true)
        {
            transform.position += Vector3.up * direction * speedMove * Time.deltaTime;

            elapsedTime += Time.deltaTime;

            if (elapsedTime > strafeTime)
            {
                yield break;
            }

            yield return null;
        }
    }

    IEnumerator Right()
    {
        float elapsedTime = 0.0f;

        int direction = Random.Range(0, 2) == 0 ? -1 : 1;

        while (true)
        {
            transform.position += Vector3.right * direction * speedMove * Time.deltaTime;

            elapsedTime += Time.deltaTime;

            if (elapsedTime > strafeTime)
            {
                yield break;
            }

            yield return null;
        }
    }
}

