using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatColor : MonoBehaviour
{
    [SerializeField] private Material myMaterial;

    private void onCollisionEnter(Collider other)
    {
        Debug.Log("ENTER");
        if (other.CompareTag("3d-model"))
        {
            myMaterial.color = Color.red;
        }
    }

    private void onCollisionExit(Collider other)
    {
        Debug.Log("EXIT");
        if (other.CompareTag("3d-model"))
        {
            myMaterial.color = Color.white;
        }
    }

}
