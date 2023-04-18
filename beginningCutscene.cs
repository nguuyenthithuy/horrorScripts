using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cutscene, player;
    public float cutsceneTime;

    void Start()
    {

        StartCoroutine(scene());
    }
    IEnumerator scene()
    {
        yield return new WaitForSeconds(cutsceneTime);
        player.SetActive(true) ;
        cutscene.SetActive(false) ;
    }
}
