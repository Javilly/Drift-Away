using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleGenerator : MonoBehaviour
{
    public GameObject[] templesLocations = new GameObject[40];
    public TestSystem myTestSystem;
    public PersonalitySystem myPersonalitySystem;
    [SerializedField]GameObject templePrefab;

    void Start()
    {
        for (int i = 0; i < templesLocations.length; i++)
        {
            GameObject thisTempleGO = Instantiate(templePrefab, templesLocations[i].transform.position, templesLocations[i].transform.rotation);
            Temple thisTemple = thisTempleGO.GetComponent<Temple>();
            thisTemple.id = i;
            thisTemple.myPersonalitySystem = myPersonalitySystem;
            thisTemple.myTestSystem = myTestSystem;
            thisTemple.question = myTestSystem.questions[i]
        }
    }
}
