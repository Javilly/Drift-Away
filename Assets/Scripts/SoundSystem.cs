using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    [SerializeField] AudioClip[] instrumentsArray = new AudioClip[5];

    AudioSource playerAudioSource;
    [SerializeField]GameObject player;

    public int playerInstrumentId;
    public float playerPitch;

    private void Start()
    {
        playerAudioSource = GetComponent<AudioSource>();
    }

    public void generateSound(float characterSN, float characterEI)
    {
        int instrumentId = 0;

        if (characterSN < 20)
        {
            instrumentId = 0;
        }
        else if (characterSN >= 20 && characterSN < 40)
        {
            instrumentId = 1;
        }
        else if (characterSN >= 40 && characterSN < 60)
        {
            instrumentId = 2;
        }
        else if (characterSN >= 60 && characterSN < 80)
        {
            instrumentId = 3;
        }
        else if (characterSN >= 80)
        {
            instrumentId = 4;
        }

        characterEI = (characterEI * 0.015f) + 0.5f;
        playerAudioSource.clip = instrumentsArray[instrumentId];
        playerAudioSource.pitch = characterEI;
        playerAudioSource.Play();
    }

    public void generatePlayerSound()
    {
        if(!audplayerAudioSourceio.isPlaying)
         {
                     playerAudioSource.clip = instrumentsArray[playerInstrumentId];
        playerAudioSource.pitch = playerPitch;
        playerAudioSource.Play();
         }

    }
}
