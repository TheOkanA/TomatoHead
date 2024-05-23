using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButton : MonoBehaviour
{
   public GameObject Resume_C;
   public GameObject Quit;
   public GameObject PausePanel;

    private void Awake()
    {
        Resume_C = GameObject.Find("Resume_C");
        Quit = GameObject.Find("Quit");
        PausePanel = GameObject.Find("PausePanel");
        PausePanel.SetActive(false);

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void ResumeQuit()
    {
        if (Resume_C.activeSelf == false)
        {
            Resume_C.SetActive(true);
        }
        else
        {
            Resume_C.SetActive(false);
        }
        if (Quit.activeSelf == true)
        {
            Quit.SetActive(false);
        }
        else
        {  
            Quit.SetActive(true); 
        }
    }

    public void ChooseButton()
    {
        if (Resume_C.activeSelf == true)
        {
            PausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

}

/* public void ExitGame()
{
    Application.Quit();
}
public void NewGame()
{
    SceneManager.LoadScene(1);
}
public void GoMainMenu()
{
    SceneManager.LoadScene(0);
}
*/