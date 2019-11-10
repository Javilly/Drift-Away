using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSystem : MonoBehaviour
{
    [SerializeField] Mesh[] meshesArray = new Mesh[20];
    [SerializeField] GameObject playerHead;

    MeshFilter playerHeadMeshFilter;

    public int playerMeshId;

    private void Start()
    {
        playerHeadMeshFilter = playerHead.GetComponent<MeshFilter>();
    }

    void Update()
    {
        playerHeadMeshFilter.mesh = meshesArray[playerMeshId];
    }
}
