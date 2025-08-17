using UnityEngine;

public class Ponedora : MonoBehaviour
{
    public GameObject Huevo;
    public float intervalo = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(ponerHuevo), intervalo, intervalo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ponerHuevo ()
    {
        Instantiate(Huevo, transform.position, Quaternion.identity);
    }
}
