using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetectors : MonoBehaviour
{
    [SerializeField]Temple myTemple;
    [SerializeField] GameObject doorCloser;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            myTemple.TempleStarted();
            doorCloser.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
