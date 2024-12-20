using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float triggerValueRight = pinchAnimationAction.action.ReadValue<float>();
       float grabValueRight = gripAnimationAction.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", triggerValueRight);
        handAnimator.SetFloat("Grip",grabValueRight );
    }
}
