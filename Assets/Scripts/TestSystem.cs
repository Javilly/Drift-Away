using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSystem : MonoBehaviour
{
    public string[] questions = new string[70];
    public string[] firstAnswers = new string[70];
    public string[] secondAnswers = new string[70];
    public string[] answers = new string[70];

    int extraversionPoints;
    int introversionPoints;
    int sensingPoints;
    int intuitionPoints;
    int thinkingPoints;
    int feelingPoints;
    int judgingPoints;
    int perceivingPoints;

    int questionsAnswered;

    public PersonalitySystem myPersonalitySystem;

    public void addAnswer(int id, string response)
    {
        questions[id] = response;
        questionsAnswered ++;
        if(questionsAnswered == 70){
            // Teleport player to center
        }
    }

    public void calculatePersonality()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            if(i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36 || i == 43 || i == 50 || i == 57 || i == 64)
            {
                if(answers[i] == "a")
                {
                    extraversionPoints++;
                }
                else
                {
                    introversionPoints++;
                }
            }
            if (i == 2
                || i == 9
                || i == 16
                || i == 23
                || i == 30
                || i == 37
                || i == 44
                || i == 51
                || i == 58
                || i == 65
                || i == 3
                || i == 10
                || i == 17
                || i == 24
                || i == 31
                || i == 38
                || i == 45
                || i == 52
                || i == 59
                || i == 66
                )
            {
                if (answers[i] == "a")
                {
                    sensingPoints++;
                }
                else
                {
                    intuitionPoints++;
                }
            }
            if (i == 4
                || i == 11
                || i == 18
                || i == 25
                || i == 32
                || i == 39
                || i == 46
                || i == 53
                || i == 60
                || i == 67
                || i == 5
                || i == 12
                || i == 19
                || i == 26
                || i == 33
                || i == 40
                || i == 47
                || i == 54
                || i == 61
                || i == 68
                )
            {
                if (answers[i] == "a")
                {
                    thinkingPoints++;
                }
                else
                {
                    feelingPoints++;
                }
            }
            if (i == 6
                || i == 13
                || i == 20
                || i == 27
                || i == 34
                || i == 41
                || i == 48
                || i == 55
                || i == 62
                || i == 69
                || i == 7
                || i == 14
                || i == 21
                || i == 28
                || i == 35
                || i == 42
                || i == 49
                || i == 56
                || i == 63
                || i == 70
                )
            {
                if (answers[i] == "a")
                {
                    judgingPoints++;
                }
                else
                {
                    perceivingPoints++;
                }
            }
        }
    }
}
