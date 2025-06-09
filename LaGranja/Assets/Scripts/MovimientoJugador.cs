using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del jugador
    public Rigidbody2D rg; // Referencia al Rigidbody2D del jugador
    public Vector2 entrada; // Entrada del jugador para el movimiento

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rg = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D del jugador
    }

    // Update is called once per frame
    void Update()
    {
        rg.linearVelocity = entrada * velocidad;
    }

    public void Moverse(InputAction.CallbackContext contexto)
    {
        entrada = contexto.ReadValue<Vector2>(); // Leer el valor de entrada del jugador
    }
}
