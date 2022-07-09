using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;
    public float jumpForce;

    public Rigidbody hips;
    public bool isGrounded;
    void Start()
    {
        //pelvis = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //if(Input.GetKey(KeyCode.KeypadEnter))
        //{
        //    pelvis.AddForce(pelvis.transform.forward)
        //}
    }


}
