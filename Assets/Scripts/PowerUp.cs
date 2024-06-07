using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerUp : MonoBehaviour
{
    public GameObject PowerUpsPanel;
    public GameObject PowerUpsDamage;
    public GameObject PowerUpsHealth;
    public GameObject PowerUpsSpeed;
    public GameObject PowerUpsHealth2;
    public int sayi = 0;
    public int sceneIndex = 0;
    public Animator sceneTransition;

    public LoseAndGameOver loseAndGameOver;
    public WalkAndJump walkAndJump;
    public MonsterHealth monsterHealth;
    // Start is called before the first frame update
    void Start()
    {
        PowerUpsDamage = GameObject.Find("PowerUpsDamage-");
        PowerUpsHealth = GameObject.Find("PowerUpsHealth-");
        PowerUpsSpeed = GameObject.Find("PowerUpsSpeed-");
        PowerUpsHealth2 = GameObject.Find("PowerUpsHealth+2");
        //PowerUpsPanel = GameObject.Find("PowerUp");

        PowerUpsPanel.SetActive(false);


    }

    void Update()
    {
        if (loseAndGameOver.controller == 3)
        {
            switch (sayi)
            {
                case 0:
                    sayi = 1;
                    break;
                case 1:
                    PowerUpsDamage.SetActive(false);
                    PowerUpsHealth.SetActive(true);
                    PowerUpsSpeed.SetActive(true);
                    break;
                case 2:
                    PowerUpsDamage.SetActive(true);
                    PowerUpsHealth.SetActive(false);
                    PowerUpsHealth2.SetActive(true);
                    PowerUpsSpeed.SetActive(true);
                    break;
                case 3:
                    PowerUpsDamage.SetActive(true);
                    PowerUpsHealth.SetActive(true);
                    PowerUpsSpeed.SetActive(false);
                    break;
                case 4:
                    sayi = 3;
                    break;
            }
        }
        else
        {
            switch (sayi)
            {
                case 0:
                    sayi = 1;
                    break;
                case 1:
                    PowerUpsDamage.SetActive(false);
                    PowerUpsHealth.SetActive(true);
                    PowerUpsSpeed.SetActive(true);
                    break;
                case 2:
                    PowerUpsDamage.SetActive(true);
                    PowerUpsHealth.SetActive(false);
                    PowerUpsHealth2.SetActive(false);
                    PowerUpsSpeed.SetActive(true);
                    break;
                case 3:
                    PowerUpsDamage.SetActive(true);
                    PowerUpsHealth.SetActive(true);
                    PowerUpsSpeed.SetActive(false);
                    break;
                case 4:
                    sayi = 3;
                    break;
            }
        }
    }

    public void RightButton()
    {
        sayi++;
        print("akjbnsdkajsbdjask");
    }

    public void LeftButton()
    {
        sayi--;
    }

    public void RedButton()
    {
        if (PowerUpsDamage.activeSelf == false)
        {
            monsterHealth.PlayerDamage += 10;
            ReloadScene();
        }
        if (PowerUpsHealth.activeSelf == false && loseAndGameOver.controller < 3)
        {
            loseAndGameOver.controller += 1;
            ReloadScene();
        }
        if (PowerUpsSpeed.activeSelf == false)
        {
            walkAndJump.moveSpeed += 1;
            ReloadScene();
        }

    }

    public GameObject yer;
    public GameObject player;
    void ReloadScene()
    {
        player.transform.position = yer.transform.position;
        //SceneManager.LoadScene(sceneIndex);
        PowerUpsPanel.SetActive(false);
        
    }
    
}
