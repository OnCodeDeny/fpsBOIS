using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    WeaponController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<WeaponController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("TriggerModeSwitch") && GetComponentInParent<PlayerWeaponsManager>().GetActiveWeapon() == controller)
        {
            if (controller.shootType == WeaponShootType.Burst)
            {
                controller.delayBetweenShots = 0.2f;
                controller.shootType = WeaponShootType.Manual;
            }
            else
            {
                controller.delayBetweenShots = 0.08f;
                controller.shootType = WeaponShootType.Burst;
            }
        }
    }
}
