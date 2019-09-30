using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 v3_movement;
    Vector3 v3_finalMovement;
    Vector3 v3_jumpForce;
    bool b_extraJump;
    bool b_wallClipPrevention;
    float f_speed;

    // Start is called before the first frame update
    void Start()
    {
        v3_movement = Vector3.zero;
        v3_jumpForce = new Vector3(0f, 3f, 0f);
        b_extraJump = true;
        f_speed = .1f;
        b_wallClipPrevention = false;
    }

    // Update is called once per frame
    void Update()
    {
        // sets current vector for player position
        v3_finalMovement = transform.position;

        // Handle base movemenet commands for player
        if (Input.GetKey(KeyCode.W))
            v3_movement = Camera.main.transform.forward.normalized * f_speed;
        if (Input.GetKey(KeyCode.A))
            v3_movement = -Camera.main.transform.right * f_speed;
        if (Input.GetKey(KeyCode.S))
            v3_movement = -Camera.main.transform.forward.normalized * f_speed;
        if (Input.GetKey(KeyCode.D))
            v3_movement = Camera.main.transform.right * f_speed;
        if (Input.GetKeyDown(KeyCode.Space) && b_extraJump)
        { GetComponent<Rigidbody>().AddForce(v3_jumpForce, ForceMode.Impulse); b_extraJump = false; }

        //v3_movement = Camera.main.transform.forward.normalized * f_speed;

        v3_finalMovement += v3_movement;

        // Apply new position to current transformation
        transform.position = v3_finalMovement;
        //Vector3.Lerp(transform.position, v3_finalMovement, Time.time);

        v3_movement = Vector3.zero;
    }
}
