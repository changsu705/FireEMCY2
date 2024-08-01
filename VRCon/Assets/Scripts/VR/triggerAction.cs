using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class triggerAction : MonoBehaviour
{
    public InputActionAsset assets;
    /*public XRController leftController;
    public XRController rightController;*/

    public InputActionProperty leftContorllerTirgger;
    private bool handcollider = false;


    void Update()
    {
        /*float distance = Vector3.Distance(plugHead.transform.position, endPoint.position);*/
        float LeftHandTrigger = assets.actionMaps[5].actions[2].ReadValue<float>();

        if(LeftHandTrigger == 1 && handcollider == true)
        {
            Debug.Log("충돌&트리거당김");
        }
        /*Debug.Log(assets.actionMaps[4].actions[0].ReadValue<Vector3>());
        Debug.Log(leftContorllerTirgger.reference.action.ReadValue<float>());*/
        
        // 왼손 컨트롤러의 트리거 버튼 입력 읽기
        //if (leftController.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool leftTriggerValue) && leftTriggerValue)
        //{
        //    Debug.Log("Left trigger button is pressed");
        //}

        //// 오른손 컨트롤러의 트리거 버튼 입력 읽기
        //if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool rightTriggerValue) && rightTriggerValue)
        //{
        //    Debug.Log("Right trigger button is pressed");
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        handcollider = true;
    }
    private void OnTriggerExit(Collider other) 
    {
         handcollider = false; 
    }



}
