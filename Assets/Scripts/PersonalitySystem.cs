using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalitySystem : MonoBehaviour
{
    [SerializeField] SoundSystem mySoundSystem;
    [SerializeField] MeshSystem myMeshSystem;

    public float introversionExtraversion;
    public float sensingIntuition;
    public float thinkingFeeling;
    public float judgingPerceiving;

    public GameObject playerHead;
    public Material playerHeadMaterial;


    private float materialColor;


    void Start()
    {
        introversionExtraversion = Random.Range(40f, 60f);
        sensingIntuition = Random.Range(40f, 60f);
        thinkingFeeling = Random.Range(40f, 60f);
        judgingPerceiving = Random.Range(40f, 60f);
    }

    public void IEChange(float value)
    {
        introversionExtraversion += value;
    }
    public void SNChange(float value)
    {
        sensingIntuition += value;
    }
    public void TFChange(float value)
    {
        thinkingFeeling += value;
    }
    public void JPChange(float value)
    {
        judgingPerceiving += value;
    }

    void Update()
    {
        //Clamps
        introversionExtraversion = Mathf.Clamp(introversionExtraversion, 0, 100);
        sensingIntuition = Mathf.Clamp(sensingIntuition, 0, 100);
        thinkingFeeling = Mathf.Clamp(thinkingFeeling, 0, 100);
        judgingPerceiving = Mathf.Clamp(judgingPerceiving, 0, 100);

        //Color
        playerHeadMaterial.color = Color.HSVToRGB(thinkingFeeling * 0.0091f, 0.7f, 0.5f);

        //Sound-Instrument
        if(sensingIntuition < 20)
        {
            mySoundSystem.playerInstrumentId = 0;
        }
        else if(sensingIntuition >= 20 && sensingIntuition < 40)
        {
            mySoundSystem.playerInstrumentId = 1;
        }
        else if (sensingIntuition >= 40 && sensingIntuition < 60)
        {
            mySoundSystem.playerInstrumentId = 2;
        }
        else if (sensingIntuition >= 60 && sensingIntuition < 80)
        {
            mySoundSystem.playerInstrumentId = 3;
        }
        else if (sensingIntuition >= 80)
        {
            mySoundSystem.playerInstrumentId = 4;
        }

        //Sound-Pitch
        mySoundSystem.playerPitch = (introversionExtraversion * 0.015f) + 0.5f;

        //Mesh
        if(judgingPerceiving < 5)
        {
            myMeshSystem.playerMeshId = 0;
        }
        else if(judgingPerceiving >= 5 && judgingPerceiving < 10)
        {
            myMeshSystem.playerMeshId = 1;
        }
        else if (judgingPerceiving >= 10 && judgingPerceiving < 15)
        {
            myMeshSystem.playerMeshId = 2;
        }
        else if (judgingPerceiving >= 15 && judgingPerceiving < 20)
        {
            myMeshSystem.playerMeshId = 3;
        }
        else if (judgingPerceiving >= 20 && judgingPerceiving < 25)
        {
            myMeshSystem.playerMeshId = 4;
        }
        else if (judgingPerceiving >= 25 && judgingPerceiving < 30)
        {
            myMeshSystem.playerMeshId = 5;
        }
        else if (judgingPerceiving >= 30 && judgingPerceiving < 35)
        {
            myMeshSystem.playerMeshId = 6;
        }
        else if (judgingPerceiving >= 35 && judgingPerceiving < 40)
        {
            myMeshSystem.playerMeshId = 7;
        }
        else if (judgingPerceiving >= 40 && judgingPerceiving < 45)
        {
            myMeshSystem.playerMeshId = 8;
        }
        else if (judgingPerceiving >= 45 && judgingPerceiving < 50)
        {
            myMeshSystem.playerMeshId = 9;
        }
        else if (judgingPerceiving >= 50 && judgingPerceiving < 55)
        {
            myMeshSystem.playerMeshId = 10;
        }
        else if (judgingPerceiving >= 55 && judgingPerceiving < 60)
        {
            myMeshSystem.playerMeshId = 11;
        }
        else if (judgingPerceiving >= 60 && judgingPerceiving < 65)
        {
            myMeshSystem.playerMeshId = 12;
        }
        else if (judgingPerceiving >= 65 && judgingPerceiving < 70)
        {
            myMeshSystem.playerMeshId = 13;
        }
        else if (judgingPerceiving >= 70 && judgingPerceiving < 75)
        {
            myMeshSystem.playerMeshId = 14;
        }
        else if (judgingPerceiving >= 75 && judgingPerceiving < 80)
        {
            myMeshSystem.playerMeshId = 15;
        }
        else if (judgingPerceiving >= 80 && judgingPerceiving < 85)
        {
            myMeshSystem.playerMeshId = 16;
        }
        else if (judgingPerceiving >= 85 && judgingPerceiving < 90)
        {
            myMeshSystem.playerMeshId = 17;
        }
        else if (judgingPerceiving >= 90 && judgingPerceiving < 95)
        {
            myMeshSystem.playerMeshId = 18;
        }
        else if (judgingPerceiving >= 95)
        {
            myMeshSystem.playerMeshId = 19;
        }

    }
}
