using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class NasalSpray : MonoBehaviour
{
    public ParticleSystem spray;

    private XRGrabInteractable grabInteractable;
    private bool isGrabbed = false;

    private enum ControllerSide
    {
        Left_Controller,
        Right_Controller
    }

    [SerializeField]
    private ControllerSide m_controller;
    private InputDeviceCharacteristics m_characteristics;

    private void Start()
    {
        // Set characteristics based on controller side
        m_characteristics = m_controller == ControllerSide.Left_Controller ?
            InputDeviceCharacteristics.Left :
            InputDeviceCharacteristics.Right;

        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.AddListener(OnGrab);
            grabInteractable.onSelectExited.AddListener(OnRelease);
        }
    }

    private void Update()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(m_characteristics, devices);

        if (devices.Count == 1)
        {
            CheckController(devices[0]);
        }
    }

    private void CheckController(InputDevice device)
    {
        bool primaryButtonDown = false;
        device.TryGetFeatureValue(CommonUsages.primaryButton, out primaryButtonDown);

        // Play the particle system if grabbed and the button is pressed
        if (isGrabbed && primaryButtonDown)
        {
            PlayParticleSystem();
        }
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        isGrabbed = true;
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        isGrabbed = false;
    }

    private void PlayParticleSystem()
    {
        if (spray != null)
        {
            spray.Play();
        }
    }

    private void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(OnGrab);
            grabInteractable.onSelectExited.RemoveListener(OnRelease);
        }
    }
}
