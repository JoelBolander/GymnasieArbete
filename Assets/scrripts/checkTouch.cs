using UnityEngine;

public class checkTouch : MonoBehaviour
{
    public bool canDrive = false;

    void OnTriggerStay(Collider collision)
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
