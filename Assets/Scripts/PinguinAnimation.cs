using UnityEngine;

public class PenguinAnimation : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;

    void Awake()
    {
        animator = GetComponentInChildren<Animator>(true);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float speed = Mathf.Abs(rb.linearVelocity.x);
        animator.SetFloat("Speed", speed);
    }
}