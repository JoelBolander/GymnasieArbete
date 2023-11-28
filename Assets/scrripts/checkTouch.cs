using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTouch : MonoBehaviour
{
    BoxCollider HCollider;
    BoxCollider VCollider;

    private BoxCollider[] BoxColliders;

    public bool canDrive = false;
    private void Start()
    {
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("ground"))
        {
            canDrive = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("ground"))
        {
            canDrive = false;
        }
    }
}
