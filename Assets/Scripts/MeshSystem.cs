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

    public Mesh getCharacterMesh(float characterJP)
    {
        Mesh meshToReturn = new Mesh();

        if (characterJP < 5)
        {
            meshToReturn = meshesArray[0];
        }
        else if (characterJP >= 5 && characterJP < 10)
        {
            meshToReturn = meshesArray[1];
        }
        else if (characterJP >= 10 && characterJP < 15)
        {
            meshToReturn = meshesArray[2];
        }
        else if (characterJP >= 15 && characterJP < 20)
        {
            meshToReturn = meshesArray[3];
        }
        else if (characterJP >= 20 && characterJP < 25)
        {
            meshToReturn = meshesArray[4];
        }
        else if (characterJP >= 25 && characterJP < 30)
        {
            meshToReturn = meshesArray[5];
        }
        else if (characterJP >= 30 && characterJP < 35)
        {
            meshToReturn = meshesArray[6];
        }
        else if (characterJP >= 35 && characterJP < 40)
        {
            meshToReturn = meshesArray[7];
        }
        else if (characterJP >= 40 && characterJP < 45)
        {
            meshToReturn = meshesArray[8];
        }
        else if (characterJP >= 45 && characterJP < 50)
        {
            meshToReturn = meshesArray[9];
        }
        else if (characterJP >= 50 && characterJP < 55)
        {
            meshToReturn = meshesArray[10];
        }
        else if (characterJP >= 55 && characterJP < 60)
        {
            meshToReturn = meshesArray[11];
        }
        else if (characterJP >= 60 && characterJP < 65)
        {
            meshToReturn = meshesArray[12];
        }
        else if (characterJP >= 65 && characterJP < 70)
        {
            meshToReturn = meshesArray[13];
        }
        else if (characterJP >= 70 && characterJP < 75)
        {
            meshToReturn = meshesArray[14];
        }
        else if (characterJP >= 75 && characterJP < 80)
        {
            meshToReturn = meshesArray[15];
        }
        else if (characterJP >= 80 && characterJP < 85)
        {
            meshToReturn = meshesArray[16];
        }
        else if (characterJP >= 85 && characterJP < 90)
        {
            meshToReturn = meshesArray[17];
        }
        else if (characterJP >= 90 && characterJP < 95)
        {
            meshToReturn = meshesArray[18];
        }
        else if (characterJP >= 95)
        {
            meshToReturn = meshesArray[19];
        }

        return meshToReturn;
    }
}
