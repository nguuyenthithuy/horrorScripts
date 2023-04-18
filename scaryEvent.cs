using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaryEvent : MonoBehaviour
{
    public GameObject scary;
    public Collider collison;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scary.SetActive(true);
            collison.enabled = false;
        }
    }
}
