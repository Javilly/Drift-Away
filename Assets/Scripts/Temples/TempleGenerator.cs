using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleGenerator : MonoBehaviour
{
    public GameObject[] templesLocations = new GameObject[40];
    public TestSystem myTestSystem;
    public PersonalitySystem myPersonalitySystem;
    [SerializeField] GameObject templePrefab;

    void Start()
    {
        for (int i = 0; i < templesLocations.Length; i++)
        {
            // If i = id de alguna pregunta/respuesta que hay que decidir mañana
            GameObject thisTempleGO = Instantiate(templePrefab, templesLocations[i].transform.position, templesLocations[i].transform.rotation);
            Temple thisTemple = thisTempleGO.GetComponent<Temple>();
            thisTemple.templeId = i;
            thisTemple.myPersonalitySystem = myPersonalitySystem;
            thisTemple.myTestSystem = myTestSystem;
            thisTemple.templeQuestion = myTestSystem.questions[i];
            thisTemple.templeFirstAnswer = myTestSystem.firstAnswers[i];
            thisTemple.templeSecondAnswer = myTestSystem.secondAnswers[i];
        }
    }
}
