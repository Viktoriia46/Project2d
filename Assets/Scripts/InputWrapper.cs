using UnityEngine;

public class InputWrapper
{
    public float HorizontalInput => Input.GetAxis("Horizontal");
    public bool JumpInput => Input.GetButtonDown("Jump");
}