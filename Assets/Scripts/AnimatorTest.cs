using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    public Animator animator;
    public string TriggerToPlay = "Fly";
    public KeyCode TriggerKey = KeyCode.A;
    public KeyCode ExitTriggerKey = KeyCode.S;

    private void OnValidate()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(TriggerKey))
        {
            animator.SetBool(TriggerToPlay, !animator.GetBool(TriggerToPlay));
        }
    }
}
