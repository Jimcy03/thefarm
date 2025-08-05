using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del jugador
    public Rigidbody2D rb; // Referencia al Rigidbody2D del jugador
    public Vector2 entrada; // Entrada del jugador para el movimiento
    public Animator animator;
    public GameObject preFabTrigo; // Prefab del trigo que se sembrará
    public GameObject preFabTomate; // Nuevo prefab para tomate

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        rb.linearVelocity = entrada * velocidad;
    }

    public void Moverse(InputAction.CallbackContext contexto)
    {
        Vector2 valorEntrada = contexto.ReadValue<Vector2>();

        // Determinar el eje dominante
        if (Mathf.Abs(valorEntrada.x) > Mathf.Abs(valorEntrada.y))
        {
            // Movimiento horizontal
            entrada = new Vector2(Mathf.Sign(valorEntrada.x), 0);
        }
        else if (Mathf.Abs(valorEntrada.y) > 0)
        {
            // Movimiento vertical
            entrada = new Vector2(0, Mathf.Sign(valorEntrada.y));
        }
        else
        {
            entrada = Vector2.zero;
        }

        animator.SetBool("estaCaminando", entrada != Vector2.zero);
    }

    public void SembrarTrigo(InputAction.CallbackContext contexto)
    {
        if (contexto.started)
        {
            Instantiate(preFabTrigo, transform.position, Quaternion.identity);
        }
    }

    // Nuevo método para sembrar tomate
    public void SembrarTomate(InputAction.CallbackContext contexto)
    {
        if (contexto.started)
        {
            Instantiate(preFabTomate, transform.position, Quaternion.identity);
        }
    }

    // Corrección: OnTriggerEnter2D (nombre correcto)
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("nido"))
        {
            Destroy(colision.gameObject);
            GameManager.instancia.SumarHuevo();
        }
    }
}