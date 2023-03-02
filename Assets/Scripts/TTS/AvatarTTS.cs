using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AvatarTTS : MonoBehaviour
{

    [TextArea(15, 20)] public string inputText;
    public static UnityEvent OnStartTalking;
    public static UnityEvent OnStopTalking;

    [HideInInspector] public bool isTalking = false;
    // Start is called before the first frame update
    void Start()
    {
        SynthesizeAudioAsync(inputText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    async void SynthesizeAudioAsync(string _inputText)
    {
        isTalking = true;

        Debug.Log("Start Speaking audio");
        OnStartTalking?.Invoke();
        await TTSManager.Instance.synthesizeAudioAsync(_inputText);
        OnStopTalking?.Invoke();
        Debug.Log("Stop Speaking audio");

        isTalking = false;

    }
}

