using UnityEngine;

public class VehicleSwitch : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private GameObject motorcycle;
    [SerializeField] private GameObject airplane;
    [SerializeField] private GameObject boat;

    private GameObject currentVehicle;

    private void Start()
    {
        ActivateVehicle(car);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ActivateVehicle(car);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ActivateVehicle(motorcycle);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            ActivateVehicle(airplane);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ActivateVehicle(boat);
        }
    }

    private void ActivateVehicle(GameObject vehicleToActivate)
    {
        car.SetActive(false);
        motorcycle.SetActive(false);
        airplane.SetActive(false);
        boat.SetActive(false);

        vehicleToActivate.SetActive(true);
        currentVehicle = vehicleToActivate;
    }
}