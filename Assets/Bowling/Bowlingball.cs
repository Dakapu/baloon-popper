using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowlingball : MonoBehaviour
{
    public float forwardForce;
    public float leftBorder;
    public float rightBorder;
    public float moveIncrement;
    public Rigidbody rig;

    public void Bowl()
    {
        rig.AddForce(transform.forward * forwardForce, ForceMode.Impulse);

    }

}
