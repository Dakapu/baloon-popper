using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    public MeshRenderer mr;
    public Color hitColor;
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collision)
    {
        mr.material.color = hitColor;
    }
}
