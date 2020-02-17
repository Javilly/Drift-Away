using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosers : MonoBehaviour
{
    [SerializeField] Temple myTemple;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            myTemple.CloseDoor();
            gameObject.SetActive(false);
        }
    }
}
