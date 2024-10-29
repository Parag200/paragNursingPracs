using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class nasalSpray : MonoBehaviour
{

    public ParticleSystem spray;

    private XRGrabInteractable grabInteractable;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.AddListener(PlayParticleSystem);
        }
    }

    private void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(PlayParticleSystem);
        }
    }

    private void PlayParticleSystem(XRBaseInteractor interactor)
    {
        if (spray != null)
        {
            spray.Play();
        }
    }
}
