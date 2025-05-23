using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffectHandler : MonoBehaviour
{
    private PlayerController controller;

    private float defaultSpeed;
    private float defaultJump;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        defaultSpeed = controller.moveSpeed;
        defaultJump = controller.jumpPower;
    }

    public void ApplySprint(float speedUp, float duration)
    {
        StopCoroutine("Sprint");
        StartCoroutine(Sprint(speedUp, duration));
    }

    public void ApplyJumpUP(float multiplier, float duration)
    {
        StopCoroutine("JumpUp");
        StartCoroutine(JumpUp(multiplier, duration));
    }

    private IEnumerator Sprint(float multiplier, float duration)
    {
        controller.moveSpeed = defaultSpeed * multiplier;
        yield return new WaitForSeconds(duration);
        controller.moveSpeed = defaultSpeed;
    }

    private IEnumerator JumpUp(float multiplier, float duration)
    {
        controller.jumpPower = defaultJump * multiplier;
        yield return new WaitForSeconds(duration);
        controller.jumpPower = defaultJump;
    }
}
