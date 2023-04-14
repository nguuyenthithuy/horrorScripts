using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public GameObject textInt, light;

    public bool toggle = true, interactable;
    public Renderer LightBuild;             // dùng ?? 1 cái mà s? dungnj ???c ??n 2 matterrial on off ? d??i(cha)
    public Material onlight, offlight;
    public Animator AnimSwitch;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            textInt.SetActive(true);
            interactable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            textInt.SetActive(false);
            interactable = false;
        }
    }
    private void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                AnimSwitch.ResetTrigger("press");
                AnimSwitch.SetTrigger("press");
            }
        }
        if(toggle == true)
        {
            light.SetActive(true);
            LightBuild.material = onlight;
        }
        if(toggle == false)
        {
            light.SetActive(false);
            LightBuild.material = offlight;
        }
    }
}
