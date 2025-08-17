using UnityEngine;
using UnityEngine.UIElements;

public class InventarioUI : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosPrevios = -1;

    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("labelHuevos");
    }

    private void Update()
    {
        if (GameManager.instancia.huevo != huevosPrevios)
        {
            // aquí programa la actualización de la interfaz, paso siguiente
            huevosPrevios = GameManager.instancia.huevo;
            labelHuevos.text = huevosPrevios.ToString();
        }
    }
}
