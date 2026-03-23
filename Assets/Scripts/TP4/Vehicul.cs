using UnityEngine;

public abstract class Vehicul : MonoBehaviour
{
    [Header("Common Stats")]
    [SerializeField] protected float speed = 0f;
    [SerializeField] protected float maxSpeed = 100f;
    [SerializeField] protected float acceleration = 10f;
    [SerializeField] protected float handling = 5f;
    [SerializeField] protected float brakeForce = 8f;

    protected virtual void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        HandleMovementInput(moveInput, turnInput);
        ClampSpeed();
        HandleSteering(moveInput, turnInput);
        MoveVehicle();
    }

    protected virtual void HandleMovementInput(float moveInput, float turnInput)
    {
        if (moveInput > 0f)
        {
            Accelerate(moveInput);
            ApplySpecialBehavior(turnInput);
        }
        else if (moveInput < 0f)
        {
            Brake(moveInput);
        }
    }

    protected virtual void ClampSpeed()
    {
        speed = Mathf.Clamp(speed, 0f, maxSpeed);
    }

    protected virtual void MoveVehicle()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected abstract void Accelerate(float moveInput);
    protected abstract void Brake(float moveInput);
    protected abstract void HandleSteering(float moveInput, float turnInput);
    protected abstract void ApplySpecialBehavior(float turnInput);
}