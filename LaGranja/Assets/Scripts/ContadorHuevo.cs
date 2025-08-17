using UnityEngine;
using UnityEngine.UIElements;

public class ContadorHuevo : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosAntes = -1;

    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("labelHuevos");
    }


    // Update is called once per frame
    void Update()
    {
        if (GameManager.instancia.huevo != huevosAntes)
        {
            huevosAntes = GameManager.instancia.huevo;
            labelHuevos.text = $"Huevos: {huevosAntes}";
        }
    }
}
