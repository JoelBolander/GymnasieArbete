using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skiptLevel : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private GameObject goalTrigger;
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            tank.transform.position = goalTrigger.transform.position;
        }
    }
}
