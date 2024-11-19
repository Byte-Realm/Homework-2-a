using UnityEngine;
using UnityEngine.InputSystem;

public class Hide : MonoBehaviour
{
    [SerializeField]
    InputAction hide = new InputAction(type: InputActionType.Button);
    private bool isVisible = true;

    private void OnEnable()
    {
        hide.Enable();
    }

    private void OnDisable()
    {
        hide.Disable(); 
    }
    // Update is called once per frame
    void Update()
    {
        if (hide.WasPressedThisFrame())
        {
            isVisible = !isVisible;
            GetComponent<Renderer>().enabled = isVisible;
        }
    }
}
