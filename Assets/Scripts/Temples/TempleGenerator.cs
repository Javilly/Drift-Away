using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleGenerator : MonoBehaviour
{
    public GameObject[] templesGO = new GameObject[40];
    public TestSystem myTestSystem;
    public PersonalitySystem myPersonalitySystem;
    [SerializeField] GameObject templePrefab;
    int[] templesQuestionAnswerIds = new int[45]{4,5,7,10,16,18,20,21,23,25,27,28,30,31,32,34,35,37,39,40,41,42,44,45,46,47,48,49,51,52,53,55,56,58,59,60,61,62,63,65,66,67,68,69,70};

    void Start()
    {
        for (int i = 0; i < templesGO.Length; i++)
        {
            Temple thisTemple = templesGO[i].GetComponent<Temple>();
            // If i = id de alguna pregunta/respuesta que hay que decidir mañana
            for (int j = 0; j < templesQuestionAnswerIds.Length; j++)
            {
                if (templesQuestionAnswerIds[j] == i)   // REVER ESTO PORQUE PUEDE TENER ERROR
                {
                    thisTemple.templeQuestionAnswerId = i;
                    thisTemple.templeQuestion = myTestSystem.questions[i];
                    thisTemple.templeFirstAnswer = myTestSystem.firstAnswers[i];
                    thisTemple.templeSecondAnswer = myTestSystem.secondAnswers[i];
                }
            }
            thisTemple.myPersonalitySystem = myPersonalitySystem;
            thisTemple.myTestSystem = myTestSystem;
        }
    }
}
