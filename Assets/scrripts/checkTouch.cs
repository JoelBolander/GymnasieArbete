using UnityEngine;

public class checkTouch : MonoBehaviour
{
    public bool canDrive = false;

    void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("ground"))
        {
            Debug.Log("can drive");
            canDrive = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("ground"))
        {
            Debug.Log("cannot drive");
            canDrive = false;
        }
    }
}
