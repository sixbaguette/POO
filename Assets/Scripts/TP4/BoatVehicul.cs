using UnityEngine;

public class BoatVehicul : Vehicul
{
    [Header("Boat Settings")]
    [SerializeField] private float boatBuoyancy = 1.5f;

    protected override void Accelerate(float moveInput)
    {
        speed += acceleration * 0.7f * moveInput * Time.deltaTime;
    }

    protected override void Brake(float moveInput)
    {
        speed -= brakeForce * 0.6f * Mathf.Abs(moveInput) * Time.deltaTime;
    }

    protected override void HandleSteering(float moveInput, float turnInput)
    {
        transform.Rotate(0f, turnInput * handling * speed * 0.05f * Time.deltaTime, 0f);
    }

    protected override void ApplySpecialBehavior(float turnInput)
    {
        ApplyBoatBuoyancy();
    }

    private void ApplyBoatBuoyancy()
    {
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 2.0f))
        {
            if (hit.collider.CompareTag("Water"))
            {
                float desiredHeight = hit.point.y + boatBuoyancy;
                Vector3 pos = transform.position;
                pos.y = Mathf.Lerp(pos.y, desiredHeight, Time.deltaTime * 2.0f);
                transform.position = pos;
            }
        }
    }
}