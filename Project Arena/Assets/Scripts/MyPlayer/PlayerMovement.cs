using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 v3_movement;
    Vector3 v3_jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        v3_movement = Vector3.zero;
        v3_jumpForce = new Vector3(0f, 3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        v3_movement = transform.position;

        if (Input.GetKey(KeyCode.W))
            v3_movement.z += .1f;
        if (Input.GetKey(KeyCode.A))
            v3_movement.x -= .1f;
        if (Input.GetKey(KeyCode.S))
            v3_movement.z -= .1f;
        if (Input.GetKey(KeyCode.D))
            v3_movement.x += .1f;
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(v3_jumpForce, ForceMode.Impulse);


        transform.position = v3_movement;
    }
}
