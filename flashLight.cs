using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashLight : MonoBehaviour
{
    public GameObject light;        // pointlight
    public bool toggle;         // check xem có b?t ?èn pin hay ch?a
    public AudioSource pointlight;

    void Start()
    {
        if (toggle == true)
        {
            light.SetActive(true);
        }
        if (toggle == false)
        {
            light.SetActive(false);
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            toggle =!toggle;

            if (toggle == true)
            {
                light.SetActive(true);
            }
            if (toggle == false)
            {
                light.SetActive(false);
            }

        }
        
    }
}
