using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 1f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (spriteRenderer == null || Camera.main == null)
            return;

        transform.position += Vector3.left * speed * Time.deltaTime;

        Camera cam = Camera.main;

        float halfWidth = cam.orthographicSize * cam.aspect;
        float left = cam.transform.position.x - halfWidth;
        float right = cam.transform.position.x + halfWidth;

        float cloudWidth = spriteRenderer.bounds.extents.x;

        if (transform.position.x + cloudWidth < left)
        {
            transform.position = new Vector3(
                right + cloudWidth,
                transform.position.y,
                transform.position.z
            );
        }
    }
}