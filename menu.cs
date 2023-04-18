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
        Cursor.visible = true;    // Xác ??nh xem con tr? ph?n c?ng có hi?n th? hay không,
                                //??t giá tr? này thành true ?? hi?n th? con tr?.??t nó thành false ?? ?n con tr?. 
         Cursor.lockState = CursorLockMode.None; // lookState ( là m?i vô con tr? vào game luôn còn = sau là không cho thay ??i con tr?
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
