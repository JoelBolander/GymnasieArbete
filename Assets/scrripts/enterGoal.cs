using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterGoal : MonoBehaviour
{
    [SerializeField] private GameObject SceneLoader;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("goalTrigger"))
        {
            SceneLoader.GetComponent<LoadLevel>().levelFinish();
        }
    }
}
