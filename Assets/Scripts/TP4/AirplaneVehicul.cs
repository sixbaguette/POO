using UnityEngine;

public class AirplaneVehicul : Vehicul
{
    [Header("Airplane Settings")]
    [SerializeField] private float airplaneLift = 5f;

    protected override void Accelerate(float moveInput)
    {
        speed += acceleration * 0.8f * moveInput * Time.deltaTime;
    }

    protected override void Brake(float moveInput)
    {
        speed -= brakeForce * 0.4f * Mathf.Abs(moveInput) * Time.deltaTime;
    }

    protected override void HandleSteering(float moveInput, float turnInput)
    {
        transform.Rotate(
            turnInput * handling * 0.5f * Time.deltaTime,
            moveInput * handling * 0.3f * Time.deltaTime,
            -turnInput * handling * Time.deltaTime
        );
    }

    protected override void ApplySpecialBehavior(float turnInput)
    {
        ApplyAirplaneLift();
    }

    private void ApplyAirplaneLift()
    {
        if (speed > maxSpeed * 0.3f)
        {
            float liftForce = airplaneLift * (speed / maxSpeed);
            transform.Translate(Vector3.up * liftForce * Time.deltaTime, Space.World);
        }
    }
}