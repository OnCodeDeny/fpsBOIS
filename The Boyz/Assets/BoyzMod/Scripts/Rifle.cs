using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    public enum TriggerMode
    {
        Single,
        //Duo,
        Burst,
    }

    public TriggerMode currentTriggerMode;

    WeaponController currentController;

    // Start is called before the first frame update
    void Start()
    {
        currentController = GetComponent<WeaponController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("TriggerModeSwitch"))
        {
            if (currentTriggerMode == TriggerMode.Burst)
            {
                currentTriggerMode = TriggerMode.Single;
            }
            else
            {
                currentTriggerMode++;
            }
        }
        if (currentTriggerMode == TriggerMode.Single)
        {
            currentController.bulletsPerShot = 1;
        }
        else if (currentTriggerMode == TriggerMode.Burst)
        {
            currentController.bulletsPerShot = 3;
        }
    }
}
