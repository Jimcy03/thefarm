using System.Collections;
using UnityEngine;

public class trigoVida : MonoBehaviour
{
    public float tiempoEspera = 8f; // Tiempo de espera en segundos
    public Animator animator; // Referencia al componente Animator
    public int estadoTrigo = 0; // Estado del trigo (0: muerto, 1: vivo)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }

    private IEnumerator CambiarEstado()
    {
        while (estadoTrigo < 4)
        {
            // Verifica si el parámetro existe
            if (ParametroExiste("estado"))
            {
                animator.SetInteger("estado", estadoTrigo);
            }
            else
            {
                Debug.LogError("Parámetro 'estado' no encontrado!");
            }

            estadoTrigo++;
            yield return new WaitForSeconds(tiempoEspera);
        }
    }

    private bool ParametroExiste(string nombre)
    {
        foreach (var param in animator.parameters)
        {
            if (param.name == nombre) return true;
        }
        return false;
    }
    void Update()
    {
        
    }
}
