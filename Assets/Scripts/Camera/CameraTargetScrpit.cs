using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetScrpit : MonoBehaviour
{
    [SerializeField] GameObject player;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPos = new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z);
        transform.position = desiredPos;
    }
}
