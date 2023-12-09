using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.InputSystem;

public class TurnStickSpeedStick : MonoBehaviour
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

    NewControls controls;

    Vector2 leftY;
    Vector2 rightX;

    private void Awake()
    {
        controls = new NewControls();

        controls.Gameplay.LeftStick.performed += ctx => leftY = ctx.ReadValue<Vector2>();
        controls.Gameplay.LeftStick.canceled += ctx => leftY = Vector2.zero;

        controls.Gameplay.RightStick.performed += ctx => rightX = ctx.ReadValue<Vector2>();
        controls.Gameplay.RightStick.canceled += ctx => rightX = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    void Start()
    {
        VCheckTouch = VLarvfot.GetComponent<checkTouch>();
        HCheckTouch = HLarvfot.GetComponent<checkTouch>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float input = leftY.y;
        float turnInput = rightX.x;

        float turn = 0f;

        float extraTurn = 1;
        if (input == 0)
        {
            extraTurn = 1.5f;
        }

        turn = turnInput * turnSpeed * extraTurn;
        rb.angularVelocity = new Vector3(0, turn, 0);

        int extraSpeed = 6;
        Vector3 force = transform.forward * movementForce * input * extraSpeed;

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
