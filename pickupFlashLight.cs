using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupFlashLight : MonoBehaviour
{
    public GameObject intText, flashLight_Table,flashLight_Hand;
    public bool intractable;
    public AudioSource pickup;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            intractable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            intractable = false;
        }
    }

    void Update()
    {
        if(intractable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                intText.SetActive(false);
                intractable = false;
                flashLight_Table.SetActive(false);
                flashLight_Hand.SetActive(true);
            }
        }    
    }

}
