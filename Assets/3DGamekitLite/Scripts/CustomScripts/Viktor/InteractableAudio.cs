using UnityEngine;
using FMOD.Studio;
using FMODUnity;

[CreateAssetMenu(fileName = "InteractableAudio", menuName = "Scriptable Objects/InteractableAudio")]
public class InteractableAudio : ScriptableObject
{
    //Declares a EventReference that holds a reference to our specific event
    [SerializeField] private EventReference pickupHealthAudio;
    [SerializeField] private EventReference boxDestroyAudio;
    [SerializeField] private EventReference doorAudio, switchAudio;

    //Declares a method that should play the health sound without any 3D-positioning
    public void PickupHealthPlay()
    {
        RuntimeManager.PlayOneShot(pickupHealthAudio);
    }

    public void BoxDestroyPlay(Transform objectTransform)
    {
        RuntimeManager.PlayOneShot(boxDestroyAudio, objectTransform.position);
    }

}
