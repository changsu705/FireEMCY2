using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class TriggerAction : MonoBehaviour
{
    public InputActionProperty leftHandTriggerAction; // Ʈ���� �׼��� ���⼭ �����մϴ�.

    void OnEnable()
    {
        leftHandTriggerAction.action.Enable();
        leftHandTriggerAction.action.performed += OnTriggerPressed;
    }

    void OnDisable()
    {
        leftHandTriggerAction.action.performed -= OnTriggerPressed;
        leftHandTriggerAction.action.Disable();
    }

    private void OnTriggerPressed(InputAction.CallbackContext context)
    {
        // Ʈ���Ű� ������ �� ������ �Լ�
        Debug.Log("Left Hand Trigger Pressed!");
        ExecuteMyFunction();
    }

    private void ExecuteMyFunction()
    {
        // ���ϴ� ������ ���⼭ ����
        Debug.Log("Executing my function!");
    }
}
