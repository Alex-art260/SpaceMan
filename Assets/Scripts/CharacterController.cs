using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Transform start;

    private Vector2 mousePos;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            start.position = gameObject.transform.position;
            mousePos = Input.mousePosition;

        }
    }
    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(start.position, Camera.main.ScreenToWorldPoint(mousePos), Time.fixedDeltaTime);
    }

}
