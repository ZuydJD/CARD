using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSpeech : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AvatarTTS.OnStartTalking.AddListener(Talk);
    }

    public void Talk()
    {
        Debug.Log("OnAvatarIsTalking");


    }

}
