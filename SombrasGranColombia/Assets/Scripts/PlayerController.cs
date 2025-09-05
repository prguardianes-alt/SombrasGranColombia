using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 6f;
    public float saltoFuerza = 14f;

    [Header("Dash")]
    public int maxDashes = 1;
    private int dashesDisponibles;

    Rigidbody2D rb;
    bool enSuelo;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        dashesDisponibles = maxDashes;
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector2 vel = rb.velocity;
        vel.x = h * velocidad;
        rb.velocity = vel;

        if (Input.GetButtonDown("Jump") && enSuelo)
            rb.velocity = new Vector2(rb.velocity.x, saltoFuerza);

        if (Input.GetButtonDown("Fire1") && dashesDisponibles > 0)
        {
            // Placeholder: dash simple horizontal
            rb.velocity = new Vector2(Mathf.Sign(transform.localScale.x) * 20f, 0f);
            dashesDisponibles--;
        }
    }

    // Chequeo simple de suelo (a mejorar en Unity con colliders)
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Traer lógica de suelo por tag:
        if (collision.gameObject.CompareTag("Suelo")) { enSuelo = true; dashesDisponibles = maxDashes; }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo")) enSuelo = false;
    }
}
