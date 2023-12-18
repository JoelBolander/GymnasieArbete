using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mus : MonoBehaviour
{

    [SerializeField] private float movementForce = 10f;
    [SerializeField] private float maxVelocity = 5f;
    [SerializeField] private float maxRotationSpeed = 1f;
    [SerializeField] private float turnSpeed = 1f;

    checkTouch VCheckTouch;
    checkTouch HCheckTouch;

    private Rigidbody rb;

    [SerializeField] private GameObject VLarvfot;
    [SerializeField] private GameObject HLarvfot;

    void Start()
    {
        VCheckTouch = VLarvfot.GetComponent<checkTouch>();
        HCheckTouch = HLarvfot.GetComponent<checkTouch>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float mid = Screen.width / 2;
        Vector3 mousePos = Input.mousePosition;
        float mouseX = mousePos.x - mid;

        float turnInput = mouseX / mid;

        if (turnInput > 1)
        {
            turnInput = 1;
        } else if (turnInput < -1)
        {
            turnInput = -1;
        }

        int speedInput = 0;
        if (Input.GetMouseButton(0) && Input.GetMouseButton(1))
        {
            speedInput = 0;
        } else if (Input.GetMouseButton(0))
        {
            speedInput = 1;
        } else if (Input.GetMouseButton(1))
        {
            speedInput = -1;
        }

        int invert = 1; 
        if (speedInput == -1)
        {
            invert = 1;
        }

        float extraRotation = 1f;
        if (speedInput == 0)
        {
            extraRotation = 1.5f;
        }

        float turn = turnInput * turnSpeed * invert * extraRotation;
        rb.angularVelocity = new Vector3(0, turn, 0);

        Vector3 force = transform.forward * movementForce * speedInput * 2;

        if (VCheckTouch.canDrive && HCheckTouch.canDrive)
        {
            rb.velocity += force * Time.fixedDeltaTime;
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

