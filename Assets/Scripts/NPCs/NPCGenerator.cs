using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    [SerializeField] MeshSystem myMeshSystem;
    [SerializeField] GameObject NPCPrefab;

    GameObject NPCHead;
    int NPCToGenerate = 1;

    [SerializeField]string[] NPC1 = new string[4];
    public List<GameObject> NPCList = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < NPCList.Count; i++)
        {
            NPCList[i] = Instantiate(NPCPrefab);
        }

        NPCList[0].GetComponent<NPC>().IE = NPC1[0];
        NPCList[0].GetComponent<NPC>().SI = NPC1[1];
        NPCList[0].GetComponent<NPC>().TF = NPC1[2];
        NPCList[0].GetComponent<NPC>().JP = NPC1[3];
    }

}
