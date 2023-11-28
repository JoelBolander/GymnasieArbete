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

    void Update()
    {
        float leftTrackInput = Input.GetAxis("LeftTrack");
        float rightTrackInput = Input.GetAxis("RightTrack");


        Vector3 leftForce = transform.forward * movementForce * leftTrackInput * Time.deltaTime;
        Vector3 rightForce = transform.forward * movementForce * rightTrackInput * Time.deltaTime;
        if (VCheckTouch.canDrive == true)
        {
            rb.AddForceAtPosition(leftForce, VLarvfot.transform.position);
        }
        if (HCheckTouch.canDrive == true)
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
