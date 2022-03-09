using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 cameraVectorForward;
    public Vector3 cameraVectorRight;
    public float verticalInput;
    public float horizontalInput;
    public float speed = 5f;

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        cameraVectorForward = Camera.main.transform.forward; cameraVectorForward.y = 0f;
        cameraVectorRight = Camera.main.transform.right; cameraVectorRight.y = 0f;
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(cameraVectorForward.normalized * Time.deltaTime * speed * verticalInput);
        transform.Translate(cameraVectorRight.normalized * Time.deltaTime * speed * horizontalInput);
    }
}
