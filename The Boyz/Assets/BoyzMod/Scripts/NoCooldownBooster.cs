using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCooldownBooster : MonoBehaviour
{
    public int noCooldownTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerWeaponsManager>())
        {
            other.gameObject.GetComponent<PlayerWeaponsManager>().NoCooldownStart(noCooldownTime);
            Destroy(gameObject);
        }
    }
}
