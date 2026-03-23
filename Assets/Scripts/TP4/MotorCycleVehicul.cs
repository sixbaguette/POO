using UnityEngine;

public class MotorcycleVehicul : Vehicul
{
    [Header("Motorcycle Settings")]
    [SerializeField] private float motorcycleLeanAngle = 25f;

    protected override void Accelerate(float moveInput)
    {
        speed += acceleration * 1.2f * moveInput * Time.deltaTime;
    }

    protected override void Brake(float moveInput)
    {
        speed -= brakeForce * 0.8f * Mathf.Abs(moveInput) * Time.deltaTime;
    }

    protected override void HandleSteering(float moveInput, float turnInput)
    {
        transform.Rotate(0f, turnInput * handling * speed * 0.15f * Time.deltaTime, 0f);
    }

    protected override void ApplySpecialBehavior(float turnInput)
    {
        ApplyMotorcycleLean(turnInput);
    }

    private void ApplyMotorcycleLean(float turnInput)
    {
        float targetLean = -turnInput * motorcycleLeanAngle;

        Vector3 currentRotation = transform.localEulerAngles;
        currentRotation.z = Mathf.LerpAngle(currentRotation.z, targetLean, Time.deltaTime * 2.0f);
        transform.localEulerAngles = currentRotation;
    }
}