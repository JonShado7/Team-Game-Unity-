﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame_Manager : MonoBehaviour
{
    public static SaveGame_Manager Instance { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveGame()
    {

    }
}
