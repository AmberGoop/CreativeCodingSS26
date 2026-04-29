using JetBrains.Annotations;
using System.Data;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10;
    private Vector3 startPosition;
    private float repeatWidth;
    void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
