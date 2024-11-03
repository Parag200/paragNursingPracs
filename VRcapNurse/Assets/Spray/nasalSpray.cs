using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class NasalSpray : MonoBehaviour
{
    public ParticleSystem spray;

    private XRGrabInteractable grabInteractable;
    private bool isGrabbed = false;
    private int sprayCount = 0; // Count of sprays used
    [SerializeField] private int maxSprays = 3; // Maximum number of sprays allowed
    [SerializeField] private float sprayCooldown = 1f; // Cooldown time in seconds
    private float lastSprayTime = 0f; // Time when the last spray occurred

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

        // Check if conditions for spraying are met
        if (isGrabbed && primaryButtonDown && sprayCount < maxSprays && Time.time >= lastSprayTime + sprayCooldown)
        {
            PlayParticleSystem();
            sprayCount++;
            lastSprayTime = Time.time; // Update the last spray time
        }
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        isGrabbed = true;
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        isGrabbed = false;
        sprayCount = 0; // Reset the spray count when released
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
