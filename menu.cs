using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject loadScenes;
    public float timeLoading;
    public string sceneName;


     void Start()
    {
        Cursor.visible = true;    // X�c ??nh xem con tr? ph?n c?ng c� hi?n th? hay kh�ng,
                                //??t gi� tr? n�y th�nh true ?? hi?n th? con tr?.??t n� th�nh false ?? ?n con tr?. 
         Cursor.lockState = CursorLockMode.None; // lookState ( l� m?i v� con tr? v�o game lu�n c�n = sau l� kh�ng cho thay ??i con tr?
    }
    public void playGame()
    {
        loadScenes.SetActive(true);
        StartCoroutine(LoadingScene());
        //SceneManager.LoadScene(sceneName);
    }
    IEnumerator LoadingScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(sceneName);
    }

    public void quit()
    {
        Debug.Log("not enough gray matter to propose");
        Application.Quit();
    }
    public void facebook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100016430322265");
    }
}
