using UnityEngine;
using UnityEngine.Tilemaps;

public class ButtonSpecial : MonoBehaviour
{
    [SerializeField] private float movementForce = 10f;
    [SerializeField] private float maxVelocity = 5f;
    [SerializeField] private float maxRotationSpeed = 90f;
    [SerializeField] private float turnSpeed = 1f;

    [SerializeField] private bool turnRight = false;

    checkTouch VCheckTouch;
    checkTouch HCheckTouch;

    private Rigidbody rb;

    [SerializeField] private GameObject VLarvfot;
    [SerializeField] private GameObject HLarvfot;

    private int leftDriving = 0;
    private int rightDriving = 0;

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
            if (leftDriving == 2)
            {
                leftDriving = 0;
            }
            else if (leftDriving == 0)
            {
                leftDriving = 1;
            } else
            {
                leftDriving = 2;
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (rightDriving == 2)
            {
                rightDriving = 0;
            }
            else if (rightDriving == 0)
            {
                rightDriving = 1;
            }
            else
            {
                rightDriving = 2;
            }
        }
    }

    void FixedUpdate()
    {


        float leftTrackInput = 0;
        if (leftDriving == 1)
        {
            leftTrackInput = 1;
        } else if (leftDriving == 2)
        {
            leftTrackInput = -1;
        }
        float rightTrackInput = 0;
        if (rightDriving == 1)
        {
            rightTrackInput = 1;
        }
        else if (rightDriving == 2)
        {
            rightTrackInput = -1;
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
