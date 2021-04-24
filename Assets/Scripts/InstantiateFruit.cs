using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateFruit : MonoBehaviour
{
    [SerializeField] public List<Transform> prefabFruit = new List<Transform>();

    public  bool show;

    private void Start()
    {
        ShowFruit();
    }

    private void Update()
    {
        foreach(Transform child in this.transform)
        {
            if(child.GetComponent<SpriteRenderer>().enabled == false)
            {
                prefabFruit.Remove(child);
            }
        }

       if(prefabFruit.Count == 0)
        {
            show = true;
            ShowFruit();
        }
        else 
        {
            show = false;
        }
    }

    private void ShowFruit()
    {
        foreach (Transform child in this.transform)
        {
            prefabFruit.Add(child);
            child.gameObject.SetActive(true);

            Vector2 pos = new Vector2(Random.Range(7f, -10f), Random.Range(-4f, 3f));
            child.transform.position = pos;
        }
    }
}
