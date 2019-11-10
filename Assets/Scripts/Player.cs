using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SoundSystem mySoundSystem;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("Generando sonido del player");
            mySoundSystem.generatePlayerSound();
        }
    }
}
