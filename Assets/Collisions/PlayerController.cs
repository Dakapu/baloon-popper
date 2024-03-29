using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce;
    public Rigidbody rig;

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");

        rig.AddForce(Vector3.right * xInput * moveForce);
    }
}
