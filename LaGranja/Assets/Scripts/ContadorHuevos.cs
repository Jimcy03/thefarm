using UnityEngine;
using UnityEngine.UIElements;

public class ContadorHuevos : MonoBehaviour
{
    private Label labelHuevos; // Usa minúscula consistente
    private int huevosAntes = -1;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("LabelHuevos"); // Asegúrate que coincide con tu UI
    }

    void Update()
    {
        // Acceso CORRECTO a través de la propiedad estática
        if (GameManager.ContadorHuevos != huevosAntes)
        {
            huevosAntes = GameManager.ContadorHuevos;
            labelHuevos.text = $"Huevo: {huevosAntes}"; // Usa llaves {}
        }
    }
}