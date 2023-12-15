using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skiptLevel : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private GameObject goalTrigger;
    [SerializeField] private GameObject sceneLoader;

    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            tank.transform.position = goalTrigger.transform.position;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            sceneLoader.GetComponent<LoadLevel>().runTimer = 90;
        }
    }
}
