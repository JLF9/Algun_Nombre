using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class PlayFmodEvent : MonoBehaviour
{

    private FMOD.Studio.EventInstance evento;

    public FMODUnity.StudioEventEmitter[] emitter;
    
    //Disparar Evento 3D
    public void PlayEvent(string PathEvento)
    {
        evento = RuntimeManager.CreateInstance(PathEvento);
        RuntimeManager.AttachInstanceToGameObject(evento, GetComponent<Transform>());
        evento.start();
    }

    //Play Emitter
    public void PlaySound(int i)
    {
        emitter[i].Play();
    }

    //Stop Emitter
    public void StopSound(int i)
    {
        emitter[i].Stop();
    }


}
