using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temple : MonoBehaviour
{
    public PersonalitySystem myPersonalitySystem;
    public TestSystem myTestSystem;
    [SerializeField] Text templeQuestionUI;
    [SerializeField] Text firstAnswerUI;
    [SerializeField] Text secondAnswerUI;
    public int templeId;
    [SerializeField] GameObject door;


    public string templeQuestion;
    public string templeFirstAnswer;
    public string templeSecondAnswer;

    public string[] questionsArray;
    public string[] firstAnswersArray;
    public string[] secondAnswerArray;

    bool templeStarted = false;
    int choice = 0;

    public void TempleStarted()
    {
        door.SetActive(true);
        templeStarted = true;
    }

    public void ReceivedFirstAnswer()
    {
        choice = 1;
        EndTemple();
    }

    public void ReceivedSecondAnswer()
    {
        choice = 2;
        EndTemple();

    }

    public void CloseDoor()
    {
        door.SetActive(true);
    }

    void EndTemple()
    {
        door.SetActive(false);
        float value = 5f;
        if(templeId == 0 || templeId == 7 || templeId == 14 || templeId == 21)
        {
            if(choice == 1)
            {
                myPersonalitySystem.IEChange(value);
            }
            else if(choice == 2)
            {
                myPersonalitySystem.IEChange(-value);
            }
        }
        else if (templeId == 1 || templeId == 8 || templeId == 15 || templeId == 22)
        {
            if (choice == 1)
            {
                myPersonalitySystem.SNChange(value);
            }
            else if (choice == 2)
            {
                myPersonalitySystem.SNChange(-value);
            }
        }
        else if (templeId == 2 || templeId == 9 || templeId == 16 || templeId == 23)
        {
            if (choice == 1)
            {
                myPersonalitySystem.TFChange(value);
            }
            else if (choice == 2)
            {
                myPersonalitySystem.TFChange(-value);
            }
        }
        else if (templeId == 3 || templeId == 10 || templeId == 17 || templeId == 24)
        {
            if (choice == 1)
            {
                myPersonalitySystem.JPChange(value);
            }
            else if (choice == 2)
            {
                myPersonalitySystem.JPChange(-value);
            }
        }

        templeQuestionUI.text = "This temple is now sealed by your decisions";
        firstAnswerUI.text = "";
        secondAnswerUI.text = "";
    }

    void Start()
    {
        templeQuestionUI.text = questionsArray[templeId];
        firstAnswerUI.text = firstAnswersArray[templeId];
        secondAnswerUI.text = secondAnswerArray[templeId];
    }



    void Update()
    {
        
    }
}
