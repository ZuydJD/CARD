using Microsoft.CognitiveServices.Speech;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TTSManager : Singleton<TTSManager>
{
    public SpeechConfig config;
    public SpeechSynthesizer synthesizer;
    //private const int AMPLITUDE_MULTIPLIER = 10;
    public override void Awake()
    {
        base.Awake();
        config = SpeechConfig.FromSubscription("8156745855a94d0294fe9da21bf5ba9d", "westeurope");

        config.SpeechSynthesisVoiceName = "nl-NL-MaartenNeural";
        synthesizer = new SpeechSynthesizer(config);
    }

    public async Task synthesizeAudioAsync(string text)
    {
        var result = await synthesizer.SpeakTextAsync(text);
        //float amp = GetAmplitude(result.AudioData);
        
        //SetBlendShapeWeights(amp);
        //using var stream = AudioDataStream.FromResult(result);

    }

    //private float GetAmplitude(byte[] audioBytes)
    //{
            //var amplitude = 0f;
            

            //foreach (var sample in audioBytes)
            //{
                //amplitude += Mathf.Abs(sample);
            //}

            //return Mathf.Clamp01(amplitude / audioBytes.Length * AMPLITUDE_MULTIPLIER);
        

        //return 0;
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
