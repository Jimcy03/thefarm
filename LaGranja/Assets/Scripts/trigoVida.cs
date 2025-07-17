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
        while (estadoTrigo < 4){
            animator.SetInteger("estado", estadoTrigo);
            estadoTrigo++;
            yield return new WaitForSeconds(tiempoEspera);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
