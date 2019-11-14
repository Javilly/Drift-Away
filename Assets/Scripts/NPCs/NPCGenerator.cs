using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    [SerializeField] MeshSystem myMeshSystem;
    [SerializeField] GameObject NPCPrefab;
    [SerializeField] GameObject[] houses;

    GameObject NPCHead;
    int NPCToGenerate = 1;

    [SerializeField] string[] NPC1 = new string[4];
    [SerializeField] string[] NPC2 = new string[4];
    [SerializeField] string[] NPC3 = new string[4];
    [SerializeField] string[] NPC4 = new string[4];
    public List<GameObject> NPCList = new List<GameObject>();

    private void Start()
    {
        houses = GameObject.FindGameObjectsWithTag("NPCHouse");

        for (int i = 0; i < NPCList.Count; i++)
        {
            NPCList[i] = Instantiate(NPCPrefab, houses[i].transform);
            NPCList[i].transform.Translate(new Vector3(-2, 0, -2));
            //NPCList[i].transform.position = new Vector3(houses[i].transform.position.x, houses[i].transform.position.y, houses[i].transform.position.z);
        }

        NPCList[0].GetComponent<NPC>().IE = NPC1[0];
        NPCList[0].GetComponent<NPC>().SI = NPC1[1];
        NPCList[0].GetComponent<NPC>().TF = NPC1[2];
        NPCList[0].GetComponent<NPC>().JP = NPC1[3];
    }

}
