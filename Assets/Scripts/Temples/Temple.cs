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
    public int templeQuestionAnswerId;
    [SerializeField] GameObject door;


    public string templeQuestion;
    public string templeFirstAnswer;
    public string templeSecondAnswer;

    // public string[] questionsArray;
    // public string[] firstAnswersArray;
    // public string[] secondAnswerArray;

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
        string response;
        if(choice == 1){
            response = 'a'.ToString();
            templeQuestionUI.text = templeFirstAnswer;
        }else{
            response = 'b'.ToString();
            templeQuestionUI.text = templeSecondAnswer;
        }
        myTestSystem.addAnswer(templeQuestionAnswerId, response);

        // templeQuestionUI.text = "This temple is now sealed by your decisions";
        firstAnswerUI.text = "";
        secondAnswerUI.text = "";

        // if(templeQuestionAnswerId == 0 || templeQuestionAnswerId == 7 || templeQuestionAnswerId == 14 || templeQuestionAnswerId == 21)
        // {
        //     if(choice == 1)
        //     {
        //         myPersonalitySystem.IEChange(value);
        //     }
        //     else if(choice == 2)
        //     {
        //         myPersonalitySystem.IEChange(-value);
        //     }
        // }
        // else if (templeQuestionAnswerId == 1 || templeQuestionAnswerId == 8 || templeQuestionAnswerId == 15 || templeQuestionAnswerId == 22)
        // {
        //     if (choice == 1)
        //     {
        //         myPersonalitySystem.SNChange(value);
        //     }
        //     else if (choice == 2)
        //     {
        //         myPersonalitySystem.SNChange(-value);
        //     }
        // }
        // else if (templeQuestionAnswerId == 2 || templeQuestionAnswerId == 9 || templeQuestionAnswerId == 16 || templeQuestionAnswerId == 23)
        // {
        //     if (choice == 1)
        //     {
        //         myPersonalitySystem.TFChange(value);
        //     }
        //     else if (choice == 2)
        //     {
        //         myPersonalitySystem.TFChange(-value);
        //     }
        // }
        // else if (templeQuestionAnswerId == 3 || templeQuestionAnswerId == 10 || templeQuestionAnswerId == 17 || templeQuestionAnswerId == 24)
        // {
        //     if (choice == 1)
        //     {
        //         myPersonalitySystem.JPChange(value);
        //     }
        //     else if (choice == 2)
        //     {
        //         myPersonalitySystem.JPChange(-value);
        //     }
        // }
    }

    void Start()
    {
        templeQuestionUI.text = templeQuestion;
        firstAnswerUI.text = templeFirstAnswer;
        secondAnswerUI.text = templeSecondAnswer;
    }
}
