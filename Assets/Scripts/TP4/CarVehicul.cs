using UnityEngine;

public class CarVehicul : Vehicul
{
    [Header("Car Settings")]
    [SerializeField] private float carTraction = 0.9f;

    protected override void Accelerate(float moveInput)
    {
        speed += acceleration * moveInput * Time.deltaTime;
    }

    protected override void Brake(float moveInput)
    {
        speed -= brakeForce * Mathf.Abs(moveInput) * Time.deltaTime;
    }

    protected override void HandleSteering(float moveInput, float turnInput)
    {
        transform.Rotate(0f, turnInput * handling * speed * 0.1f * Time.deltaTime, 0f);
    }

    protected override void ApplySpecialBehavior(float turnInput)
    {
        ApplyCarTraction();
    }

    private void ApplyCarTraction()
    {
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 1.0f))
        {
            float surfaceFactor = 1.0f;

            if (hit.collider.CompareTag("Dirt"))
                surfaceFactor = 0.7f;

            if (hit.collider.CompareTag("Ice"))
                surfaceFactor = 0.3f;

            speed *= (1.0f - (1.0f - carTraction) * (1.0f - surfaceFactor));
        }
    }
}