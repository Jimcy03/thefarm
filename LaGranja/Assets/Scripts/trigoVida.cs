using System.Collections;
using UnityEngine;

public class trigoVida : MonoBehaviour
{
    public float tiempoEspera = 8f; // Tiempo de espera en segundos
    public Animator animator; // Referencia al componente Animator
    private int estadoTrigo = 0; // Estado del trigo (0-3)

    void Start()
    {
        animator = GetComponent<Animator>();

        // Verificar que el animator tiene el par�metro "estado"
        if (!TieneParametro("estado"))
        {
            Debug.LogError("Falta el par�metro 'estado' en el Animator. Aseg�rate de:");
            Debug.LogError("1. Abrir el Animator Controller");
            Debug.LogError("2. Ir a la pesta�a Parameters");
            Debug.LogError("3. Crear un par�metro Int llamado 'estado'");
        }
        else
        {
            StartCoroutine(CicloDeCrecimiento());
        }
    }

    private IEnumerator CicloDeCrecimiento()
    {
        while (estadoTrigo < 4)
        {
            animator.SetInteger("estado", estadoTrigo);
            estadoTrigo++;
            yield return new WaitForSeconds(tiempoEspera);
        }
    }

    private bool TieneParametro(string nombreParametro)
    {
        if (animator == null) return false;

        foreach (AnimatorControllerParameter param in animator.parameters)
        {
            if (param.name == nombreParametro && param.type == AnimatorControllerParameterType.Int)
            {
                return true;
            }
        }
        return false;
    }
}