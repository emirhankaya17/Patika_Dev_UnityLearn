using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdownMovement : MonoBehaviour
{
    public float boundY = 1f;
    public float speed = 5f;
    public Vector3 offset;
    public bool direction = true;

    private void Start()
    {
        offset = transform.position;
    }

    private void Update()
    {
        if(direction)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            if (transform.position.y - offset.y > boundY)
                direction = false;
        }
        else if (!direction)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            if (transform.position.y - offset.y < -boundY)
                direction = true;
        }
    }

}
