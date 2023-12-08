using UnityEngine;
using UnityEngine.Tilemaps;

public class Button : MonoBehaviour
{
    [SerializeField] private float movementForce = 10f;
    [SerializeField] private float maxVelocity = 5f;
    [SerializeField] private float maxRotationSpeed = 90f;
    [SerializeField] private float turnSpeed = 1f;

    checkTouch VCheckTouch;
    checkTouch HCheckTouch;

    private Rigidbody rb;

    [SerializeField] private GameObject VLarvfot;
    [SerializeField] private GameObject HLarvfot;

    private bool leftDriving = false;
    private bool rightDriving = false;

    void Start()
    {
        VCheckTouch = VLarvfot.GetComponent<checkTouch>();
        HCheckTouch = HLarvfot.GetComponent<checkTouch>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (leftDriving)
            {
                leftDriving = false;
            }
            else
            {
                leftDriving = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (rightDriving)
            {
                rightDriving = false;
            }
            else
            {
                rightDriving = true;
            }
        }
    }

    void FixedUpdate()
    {


        float leftTrackInput = 0;
        if (leftDriving)
        {
            leftTrackInput = 1;
        }
        float rightTrackInput = 0;
        if (rightDriving)
        {
            rightTrackInput = 1;
        }

        Vector3 leftForce = new Vector3(0, 0, 0);
        Vector3 rightForce = new Vector3(0, 0, 0);

        float turn = 0f;

        int extra = 1;

        if (leftTrackInput > 0.9 && VCheckTouch.canDrive && rightTrackInput < -0.9)
        {
            rb.angularVelocity = new Vector3(0, 0.016f * maxRotationSpeed, 0);
        }
        else if (leftTrackInput < -0.9 && VCheckTouch.canDrive && rightTrackInput > 0.9)
        {
            rb.angularVelocity = new Vector3(0, -0.016f * maxRotationSpeed, 0);
        }
        else
        {
            turn = (leftTrackInput - rightTrackInput) * turnSpeed;
            rb.angularVelocity = new Vector3(0, turn, 0);
            extra = 3;
        }

        leftForce = transform.forward * movementForce * leftTrackInput * extra;
        rightForce = transform.forward * movementForce * rightTrackInput * extra;

        if (VCheckTouch.canDrive)
        {
            rb.velocity += leftForce * Time.fixedDeltaTime;
        }
        if (HCheckTouch.canDrive)
        {
            rb.velocity += rightForce * Time.fixedDeltaTime;
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
