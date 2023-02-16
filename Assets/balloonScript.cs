using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class balloonScript : MonoBehaviour
{
    private int life = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (life > 0)
        {
            transform.localScale += new Vector3(1, 1, 1);
            life--;

        }

        else
            Destroy(gameObject);

        Debug.Log("life: " + life);
    }


}
