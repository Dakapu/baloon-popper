using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    private Component[] treeComponents;
    public Material leafHitMaterial;
    public Material treeHitMaterial;
    private void Start()
    {
        treeComponents = GetComponentsInChildren<MeshRenderer>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        // mr.material.color = hitColor;
        foreach (Component comp in treeComponents)
        {
            if(comp.name == "Leaf")
                comp.GetComponent<MeshRenderer>().material = leafHitMaterial;
            else
                comp.GetComponent<MeshRenderer>().material = treeHitMaterial;

        }

    }
}
