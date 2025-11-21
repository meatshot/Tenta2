using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyBind : MonoBehaviour
{

    public InputActionAsset maxPlayerAction;
    public Animator maxAnimator;
    
    // Update is called once per frame
    void Update()
    {
        if (maxPlayerAction.FindAction("Move").IsPressed())
        {
            maxAnimator.SetBool("running", true);
        }
        else
            maxAnimator.SetBool("running", false);
    }
}
