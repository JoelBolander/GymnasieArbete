using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mus : MonoBehaviour
{

    [SerializeField] private float movementForce = 10f;
    [SerializeField] private float maxVelocity = 5f;
    [SerializeField] private float maxRotationSpeed = 1f;

    private int num = 0;

    checkTouch VCheckTouch;
    checkTouch HCheckTouch;

    private Rigidbody rb;

    [SerializeField] private GameObject VLarvfot;
    [SerializeField] private GameObject HLarvfot;

    private float leftTrackInput = 0;
    private float rightTrackInput = 0;

    void Start()
    {
        VCheckTouch = VLarvfot.GetComponent<checkTouch>();
        HCheckTouch = HLarvfot.GetComponent<checkTouch>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float mid = Screen.width / 2;
        Vector3 mousePos = Input.mousePosition;
        float mouseX = mousePos.x - mid;

        if (mouseX == 0)
        {
            leftTrackInput = 1f;
            rightTrackInput = 1f;
        } else if (mouseX < 0)
        {
            mouseX = mouseX * -1;
            leftTrackInput = mouseX / (mid / 2);
            rightTrackInput = 1f;
            if (leftTrackInput > 1)
            {
                leftTrackInput = 1;
            }
            leftTrackInput = 1 - leftTrackInput;
        }
        else
        {
            rightTrackInput = mouseX / (mid / 2);
            leftTrackInput = 1f;
            if (rightTrackInput > 1)
            {
                rightTrackInput = 1;
            }
            rightTrackInput = 1 - rightTrackInput;
        }

        //Debug.Log(rightTrackInput);
        //Debug.Log(leftTrackInput);
        Vector3 leftForce = transform.forward * movementForce * leftTrackInput * Time.deltaTime;
        Vector3 rightForce = transform.forward * movementForce * rightTrackInput * Time.deltaTime;
        Debug.Log(VCheckTouch.canDrive);
        Debug.Log(HCheckTouch.canDrive);
        if (VCheckTouch.canDrive)
        {
            rb.AddForceAtPosition(leftForce, VLarvfot.transform.position);
        }
        if (HCheckTouch.canDrive)
        {
            rb.AddForceAtPosition(rightForce, HLarvfot.transform.position);
        }

        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = rb.velocity.normalized * maxVelocity;
        }

        if (rb.angularVelocity.magnitude > maxRotationSpeed)
        {
            rb.angularVelocity = rb.angularVelocity.normalized * maxRotationSpeed;
        }
    }
}

