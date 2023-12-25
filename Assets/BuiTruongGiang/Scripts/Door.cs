using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update

    Vector2 endPos;
    bool isOpen = false;
    float speed = 0.01f;
    void Start()
    {
        endPos = (Vector2)transform.position + Vector2.down*20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
            Opening();
    }

    public void Opening()
    {
        Vector2 currentPos = transform.position;
        if(currentPos.y > endPos.y)
        { 
            Vector2 newPos = currentPos += Vector2.down * speed;
            transform.position = newPos;
        }
    }

    public void Open()
    {
        isOpen = true;
    }
}
