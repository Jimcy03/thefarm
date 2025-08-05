using UnityEngine;
using UnityEngine.UIElements;

public class ContadorHuevos : MonoBehaviour
{
    private Label labelHuevos; // Usa min�scula consistente
    private int huevosAntes = -1;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("LabelHuevos"); // Aseg�rate que coincide con tu UI
    }

    void Update()
    {
        // Acceso CORRECTO a trav�s de la propiedad est�tica
        if (GameManager.ContadorHuevos != huevosAntes)
        {
            huevosAntes = GameManager.ContadorHuevos;
            labelHuevos.text = $"Huevo: {huevosAntes}"; // Usa llaves {}
        }
    }
}