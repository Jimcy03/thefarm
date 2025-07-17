using UnityEngine;


public class Ponedora : MonoBehaviour
{
    public GameObject huevo;
    public float intervalo = 5f; // Intervalo en segundos para poner un huevo


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //invocar ponerhuevo()
        InvokeRepeating(nameof(PonerHuevo), intervalo, intervalo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PonerHuevo()
    {
       Instantiate(huevo, transform.position, Quaternion.identity);
    }
}
