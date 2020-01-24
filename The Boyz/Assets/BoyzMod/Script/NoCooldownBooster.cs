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

        other.SendMessage("StartCoroutine(NoCooldownStart)", noCooldownTime, SendMessageOptions.DontRequireReceiver);
        if (other.gameObject.GetComponent<PlayerWeaponsManager>())
        {
            StartCoroutine(other.gameObject.GetComponent<PlayerWeaponsManager>().NoCooldownStart(0));

        }
        Destroy(gameObject);
    }
}
