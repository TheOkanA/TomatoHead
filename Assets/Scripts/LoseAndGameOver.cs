using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseAndGameOver : MonoBehaviour
{

    public PlayerHealth playerHealth;

    public GameObject YouLosePanel, GameOverPanel, HealthSlot1, HealthSlot2, HealthSlot3;

    public int controller = 2;

    public int scene;

    public int currentscene;

    public bool level = false;
    public GameObject playla;
    public GameObject chakpos;

    void Start()
    {
        YouLosePanel = GameObject.Find("YouLosePanel");
        GameOverPanel = GameObject.Find("GameOverPanel");
        HealthSlot1 = GameObject.Find("HealthSlot1");
        HealthSlot2 = GameObject.Find("HealthSlot2");
        HealthSlot3 = GameObject.Find("HealthSlot3");

        YouLosePanel.SetActive(false);
        GameOverPanel.SetActive(false);
        HealthSlot1.SetActive(false);
        HealthSlot2.SetActive(false);
        HealthSlot3.SetActive(false);


    }

    void Update()
    {
        if (playerHealth.health == 0)
        {
            Invoke("decresecontroller", 4f);
            switch (controller)
            {
                case 0:
                    GameOverPanel.SetActive(true);
                    Invoke("GameOverPanelController", 3f);
                    break;
                case 1:
                    YouLosePanel.SetActive(true);
                    Invoke("YouLosePanelController", 1f);
                    if (level)
                    {
                        
                        Debug.LogWarning("chekoooo");
                        //SceneManager.LoadScene("Level1");
                        playla.transform.position = chakpos.transform.position;
                    }
                    else
                    {
                        
                        SceneManager.LoadScene("Level1");
                    }
                    break;
                case 2:
                    YouLosePanel.SetActive(true);
                    Invoke("YouLosePanelController", 1f);
                    break;
            }
        }
        switch (controller)
        {
                case 0:
                    HealthSlot1.SetActive(false);
                    HealthSlot2.SetActive(false);
                    HealthSlot3.SetActive(false);
                    break;
                case 1:
                    HealthSlot1.SetActive(true);
                    HealthSlot2.SetActive(false);
                    HealthSlot3.SetActive(false);
                    break;
                case 2:
                    HealthSlot1.SetActive(true);
                    HealthSlot2.SetActive(true);
                    HealthSlot3.SetActive(false);
                    break;
                case 3:
                    HealthSlot1.SetActive(true);
                    HealthSlot2.SetActive(true);
                    HealthSlot3.SetActive(true);
                    break;
        }
        

    }


    void GameOverPanelController()
    { 
        GameOverPanel.SetActive(false);
        SceneManager.LoadScene(scene);
    }

    void YouLosePanelController()
    {
        YouLosePanel.SetActive(false);
    }

    void decresecontroller()
    {
        controller -= 1;
    }

}
