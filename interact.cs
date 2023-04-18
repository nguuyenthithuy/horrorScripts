using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interact : MonoBehaviour
{
    public GameObject intText, dialogue; // 
    public bool toogle, intractable;
    public string dialogueString; 
    public Text dialogueText; // de lat doi chu trong dialogue

    public float dialogueTime;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (toogle == false)
            {
                intText.SetActive(true);
                intractable = true;
            }
           
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
        if (intractable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueText.text = dialogueString; // doi chu
                dialogue.SetActive(true);           // khi do dialogue se la dialogueString 
                intText.SetActive(false);
                toogle = true;
                StartCoroutine(DelayDialogue());
            }
        }
    }
    IEnumerator DelayDialogue()
    {
        yield return new WaitForSeconds(dialogueTime);
        dialogue.SetActive(false);
    }

}
