using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class balloonScript : MonoBehaviour
{
    public int life = 5;
    public int score = 0;
    public float scaleToIncrease = 0.5f;

    void Start()
    {
        Material redMaterial = Resources.Load("redBalloonMaterial", typeof(Material)) as Material;
        Material greenMaterial = Resources.Load("greenBalloonMaterial", typeof(Material)) as Material;
        Material blueMaterial = Resources.Load("blueBalloonMaterial", typeof(Material)) as Material;

        Material[] matArray = new Material[3];
        matArray[0] = redMaterial;
        matArray[1] = greenMaterial;
        matArray[2] = blueMaterial;

        this.GetComponent<Renderer>().material = matArray[Random.Range(0,3)];

    }


    private void OnMouseDown()
    {
        if (life > 0)
        {
            transform.localScale += Vector3.one * scaleToIncrease;
            life--;

        }

        else
            Destroy(gameObject);

        Debug.Log("life: " + life);
    }


}
