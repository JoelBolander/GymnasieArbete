using UnityEngine;

public class Diff : MonoBehaviour
{
    [SerializeField] private float movementForce = 10f;
    [SerializeField] private float maxVelocity = 5f;
    [SerializeField] private float maxRotationSpeed = 90f;

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
        float leftTrackInput = Input.GetAxis("LeftTrack");
        float rightTrackInput = Input.GetAxis("RightTrack");

        Vector3 leftForce = transform.forward * movementForce * leftTrackInput;
        Vector3 rightForce = transform.forward * movementForce * rightTrackInput;

        Debug.Log(rb.angularVelocity);
        if (VCheckTouch.canDrive == true)
        {
            // Set velocity instead of adding force
            rb.velocity += leftForce * Time.fixedDeltaTime;
        }
        if (HCheckTouch.canDrive == true)
        {
            // Set velocity instead of adding force
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

        if (rb.angularVelocity.y > 0)
        {
            rb.angularVelocity = new Vector3(0, rb.angularVelocity.y, 0);
        }
    }
}
