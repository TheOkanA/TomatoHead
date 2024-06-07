using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChange : MonoBehaviour
{
    [SerializeField] float LoadDelay = 1f;
    public int sceneIndex;
    public PowerUp powerUp;
    
    
    void OnTriggerStay2D(Collider2D other)
    {
        print("asjd");
        if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Player")
        {
            powerUp.PowerUpsPanel.SetActive(true);
            
        }
    }

}
