using UnityEngine;
using UnityEngine.Tilemaps;

public class WASD : MonoBehaviour
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

    float input = 0;
    float turnInput = 0;
    int invert = 1;
    float extraTurn = 1;


    void Start()
    {
        VCheckTouch = VLarvfot.GetComponent<checkTouch>();
        HCheckTouch = HLarvfot.GetComponent<checkTouch>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        input = 0;

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            input = 0;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            input = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            input = -1;
        }

        turnInput = 0f;

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            turnInput = 0;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            turnInput = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            turnInput = 1;
        }

        if (input == -1)
        {
            invert = 1;
        } else
        {
            invert = 1;
        }

        if (input == 0)
        {
            extraTurn = 1.5f;
        } else
        {
            extraTurn = 1;
        }
    }

    void FixedUpdate()
    {
        float turn = turnInput * turnSpeed * extraTurn * invert;
        rb.angularVelocity = new Vector3(0, turn, 0);

        Vector3 force = transform.forward * movementForce * input * 10000000;

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
