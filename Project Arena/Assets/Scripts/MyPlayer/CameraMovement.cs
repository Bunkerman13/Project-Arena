using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float f_speed;
    float f_rotationX;
    float f_rotationY;

    // Start is called before the first frame update
    void Start()
    {
        f_speed = 100f;
        f_rotationX = 0f;
        f_rotationY = 0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        f_rotationX += Input.GetAxis("Mouse X") * f_speed * Time.deltaTime;
        f_rotationY += Input.GetAxis("Mouse Y") * f_speed * Time.deltaTime;
        f_rotationY = Mathf.Clamp(f_rotationY, -45f, 45f);
        Camera.main.transform.localEulerAngles = new Vector3(-f_rotationY, f_rotationX, 0f);
    }
}
