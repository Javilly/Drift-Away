using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string IE;
    public string SI;
    public string TF;
    public string JP;

    [SerializeField] private float introversionExtraversion;
    [SerializeField] private float sensingIntuition;
    [SerializeField] private float thinkingFeeling;
    [SerializeField] private float judgingPerceiving;

    GameObject mySoundManager;
    SoundSystem mysoundSystem;
    GameObject myMeshManager;
    MeshSystem myMeshSystem;


    Transform thisNPCHead;


    private void Start()
    {
        mySoundManager = GameObject.Find("SoundManager");
        myMeshManager = GameObject.Find("MeshManager");

        mysoundSystem = mySoundManager.GetComponent<SoundSystem>();
        myMeshSystem = myMeshManager.GetComponent<MeshSystem>();

        thisNPCHead = transform.GetChild(0);

        if (IE == "I" || IE == "i")
        {
            introversionExtraversion = Random.Range(0, 49);
        }
        else if (IE == "E" || IE == "e")
        {
            introversionExtraversion = Random.Range(51, 100);
        }

        if (SI == "S" || SI == "s")
        {
            sensingIntuition = Random.Range(0, 49);
        }
        else if (SI == "N" || SI == "n")
        {
            sensingIntuition = Random.Range(51, 100);
        }

        if (TF == "T" || TF == "t")
        {
            thinkingFeeling = Random.Range(0, 49);
        }
        else if (TF == "F" || TF == "f")
        {
            thinkingFeeling = Random.Range(51, 100);
        }

        if (JP == "J" || JP == "j")
        {
            judgingPerceiving = Random.Range(0, 49);
        }
        else if (JP == "P" || JP == "p")
        {
            judgingPerceiving = Random.Range(51, 100);
        }

        thisNPCHead.GetComponent<MeshFilter>().mesh = myMeshSystem.getCharacterMesh(judgingPerceiving);
        thisNPCHead.GetComponent<Renderer>().material.color = Random.ColorHSV(thinkingFeeling * 0.0091f, thinkingFeeling * 0.0091f, 0.7f, 0.7f, 0.5f, 0.5f, 1, 1);
    }
}
