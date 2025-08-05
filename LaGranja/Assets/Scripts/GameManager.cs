using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public static int contadorHuevos = 0; // Variable estática para acceso global
    public int huevo;  // Variable de instancia

    // Nueva propiedad estática para acceso global
    public static int ContadorHuevos => instancia.huevo;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void SumarHuevo()
    {
        huevo++;
        Debug.Log(huevo);
    }
}