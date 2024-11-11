using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
{
    public class VazvratYpravlenya : MonoBehaviour
    {
        private CharacterControls _characterControls;
        private CameraManager _cameraManager;
        private DialogActivator _dialogActivator;

        private void Awake()
        {
            _characterControls = FindObjectOfType<CharacterControls>();
            _dialogActivator = FindObjectOfType<DialogActivator>();
            _cameraManager = FindObjectOfType<CameraManager>();
            _dialogActivator.Activated.AddListener(InputActivate);
            _dialogActivator.Deactivated.AddListener(InputDeactivate);
        }


        private void InputActivate() 
        {
            _characterControls.DialogActivate(); //�������� ������ ���������� ������� ��������� CharacterControls,
            _cameraManager.DialogActivate();
            //� ���� ��� ������������ ���������� ����. ���������� ���������� ���������
        }

        private void InputDeactivate()
        {
            _characterControls.DialogDeactivate();
            _cameraManager.DialogDeactivate();
        }
    }
}