using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class balloonScript : MonoBehaviour
{
    public int life = 5;

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
