using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class TriggerAction : MonoBehaviour
{
    public InputActionProperty leftHandTriggerAction; // 트리거 액션을 여기서 설정합니다.

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
        // 트리거가 눌렸을 때 실행할 함수
        Debug.Log("Left Hand Trigger Pressed!");
        ExecuteMyFunction();
    }

    private void ExecuteMyFunction()
    {
        // 원하는 동작을 여기서 구현
        Debug.Log("Executing my function!");
    }
}
