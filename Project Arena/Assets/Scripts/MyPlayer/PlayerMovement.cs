using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 v3_movement;
    Vector3 v3_finalMovement;
    Vector3 v3_jumpForce;
    float f_speed;
    bool b_secondJump;

    // Start is called before the first frame update
    void Start()
    {
        v3_movement = Vector3.zero;
        v3_jumpForce = new Vector3(0f, 3f, 0f);
        f_speed = 10f;
        b_secondJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Handle base movemenet commands for player
        if (Input.GetKey(KeyCode.W))
        {
            v3_movement = new Vector3(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
            v3_finalMovement = v3_movement.normalized;
        }
        if (Input.GetKey(KeyCode.A))
        {
            v3_movement = new Vector3(-Camera.main.transform.right.x, 0f, -Camera.main.transform.right.z);
            v3_finalMovement = v3_movement.normalized;
        }
        if (Input.GetKey(KeyCode.S))
        {
            v3_movement = new Vector3(-Camera.main.transform.forward.x, 0f, -Camera.main.transform.forward.z);
            v3_finalMovement = v3_movement.normalized;
        }
        if (Input.GetKey(KeyCode.D))
        {
            v3_movement = new Vector3(Camera.main.transform.right.x, 0f, Camera.main.transform.right.z);
            v3_finalMovement = v3_movement.normalized;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GetComponent<Rigidbody>().AddForce(v3_jumpForce, ForceMode.Impulse);
        }
        

        GetComponent<Rigidbody>().MovePosition(transform.position + v3_finalMovement * Time.deltaTime * f_speed);
        v3_finalMovement = Vector3.zero;


    }

    private void OnCollisionEnter(Collision collision)
    {
        //GetComponent<Rigidbody>().AddForce(-collision.transform.forward * 1.5f, ForceMode.Impulse);
       
    }
}
