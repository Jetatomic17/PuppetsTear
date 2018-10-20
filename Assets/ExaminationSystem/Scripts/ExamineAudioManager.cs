using UnityEngine;
using System.Collections;

public class ExamineAudioManager : MonoBehaviour
{
    private AudioSource mainAudio; //Private declaration to the audiosource component
    public static ExamineAudioManager instance;

    [SerializeField] private AudioClip interactSound; //Audioclip reference for the inspector

    void Awake()
    {
        mainAudio = GetComponent<AudioSource>(); //Finds the AudioSource on the this GameObject

        if (instance == null)
        {
            instance = this;
        }
    }

    public void InteractSound(int audioNumber)
    {
        if (audioNumber == 1)
        {
            mainAudio.PlayOneShot(interactSound, 1.0f);
        }

        else if (audioNumber == 2)
        {
            //Add more audio in this style if you choose to use this script
        }
    }
}
