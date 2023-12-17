using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (playerController != null)
        {
            UpdateSpriteDirection();
            UpdateAnimatorParameters();
        }
    }

    void UpdateSpriteDirection()
    {
        float horizontalSpeed = playerController.GetHorizontalSpeed();

        if (horizontalSpeed > 0 && !spriteRenderer.flipX)
        {
            spriteRenderer.flipX = true;
            transform.Translate(Vector3.right * playerController.reflectionXOffset);
        }
        else if (horizontalSpeed < 0  && spriteRenderer.flipX)
        {
            spriteRenderer.flipX = false;
            transform.Translate(Vector3.left * playerController.reflectionXOffset);
        }
    }

    void UpdateAnimatorParameters()
    {
        animator.SetBool("Jumping", playerController.IsJumping());
        animator.SetFloat("Speed", Mathf.Abs(playerController.GetHorizontalSpeed()));
    }
}