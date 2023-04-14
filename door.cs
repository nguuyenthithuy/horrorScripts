using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door : MonoBehaviour
{
    public GameObject intText; // text
    public bool toogle, intractable; // checkk xem c?a có m? hay không and xem cho t??ng tác hay ko
    public Animator doorAnim;           // animator 
    public AudioSource doorSound;  // âm thanh

   void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))  // Camera ( colider )
        {
            intText.SetActive(true);
            intractable = true;
        }
    }
    void OnTriggerExit(Collider other)
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
                toogle = !toogle;
                if (toogle ==true)
                {
                    doorAnim.ResetTrigger("close");         // không th?c hi?n
                    doorAnim.SetTrigger("open");            // th?c hi?n // ho?c có ngh?a là t? close sang open 
                }
                
                if (toogle == false)
                {
                    doorAnim.ResetTrigger("open");
                    doorAnim.SetTrigger("close");
                }
                intText.SetActive(false);
                intractable = false;
            }
        }
    }

}
