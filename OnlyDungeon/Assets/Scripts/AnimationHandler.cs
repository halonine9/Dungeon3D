using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetisMove(bool isMoving)
    {
        animator.SetBool("isMove", isMoving);
    }

    public void SetisJumping(bool isJumping)
    {
        animator.SetBool("isJumping", isJumping);
    }
    
    public void SetisGrounded(bool isGrounded)
    {
        animator.SetBool("isGrounded", isGrounded);
    }

}
