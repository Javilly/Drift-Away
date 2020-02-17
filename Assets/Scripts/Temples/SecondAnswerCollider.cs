using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondAnswerCollider : MonoBehaviour
{
    [SerializeField] Temple myTemple;
    [SerializeField] GameObject player;
    [SerializeField] GameObject templeEnd;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = new Vector3(templeEnd.transform.position.x, templeEnd.transform.position.y, templeEnd.transform.position.z);
            myTemple.ReceivedSecondAnswer();
        }
    }
}
