using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Play;
    public GameObject Info;
    public GameObject Quit;
    public int sayi = 0;
    public Animator sceneTransition;
    public bool scene;
    // Start is called before the first frame update
    void Start()
    {
        Play = GameObject.Find("Play");
        Info = GameObject.Find("Info");
        Quit = GameObject.Find("Quit");
    }

    void Update()
    {
        switch (sayi)
        {
            case 0:
                sayi = 1;
                break;
            case 1:
                Play.SetActive(false);
                Info.SetActive(true);
                Quit.SetActive(true);
                break;
            case 2:
                Play.SetActive(true);
                Info.SetActive(false);
                Quit.SetActive(true);
                break;
            case 3:
                Play.SetActive(true);
                Info.SetActive(true);
                Quit.SetActive(false);
                break;
            case 4:
                sayi = 3;
                break;
        }
    }

    public void RightButton()
    {
        sayi++;
    }

    public void LeftButton()
    {
        sayi--;
    }

    public void RedButton()
    {
        if (Play.activeSelf == false)
        {
            StartCoroutine(LoadLevel1());
        }
        if (Info.activeSelf == false)
        {
            Debug.Log("INFO");
        }
    }

    IEnumerator LoadLevel1()
    {
        sceneTransition.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
        sceneTransition.SetTrigger("Start");
    }
}
