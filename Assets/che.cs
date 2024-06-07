using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class che : MonoBehaviour
{

    public LoseAndGameOver los;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        los.level = true;
        Debug.LogWarning("ajndskjnasdndkaj");
    }
}
