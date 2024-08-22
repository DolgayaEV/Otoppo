using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DolgayaEV.Dialogs
{

    public class Dialog : MonoBehaviour
    {
        public bool AutoStart;
        public bool IsInputBack = true;
        public UnityEvent OnStarted;
        public UnityEvent OnEnded;
            
        private Fraza _currentFraza; // ��� ������ �� ��������� �������� �����. (������� ������ � �����������)
        private Fraza _firstFraza;
        private DialogActivator _dialogActivator; // ������ �� ������� ��������� 
        private DialogViey _dialogviey;
        private DialogButtons _dialogButtons;
        private BeckgraunPereklychi _beckgraunPereklychi;
        private Camera _currentCamera;
        private bool _isCurrent;

        private void Awake() // ����� ����������� /������������ ����������� 
        {
            _firstFraza = GetComponent<Fraza>(); // � ������� ������ GetComponent ������� ������ ����� ������� ��������� Fraza
            _dialogviey = FindObjectOfType<DialogViey>(); // ���� ��������� DialogViey ������� ���-�� �� ����� �� �����������. 
            _dialogButtons = FindObjectOfType<DialogButtons>(); // ���� ��������� DialogViey ������� ���-�� �� ����� �� �����������. 
            _dialogActivator = FindObjectOfType<DialogActivator>(); // ���� ��������� ��������� ������� 
            //���������� ����� ������ �������� _dialogActivator - ������, ��� ���� �� �� �������� null, _dialogActivator = null,
            _beckgraunPereklychi = FindObjectOfType<BeckgraunPereklychi>();
        }

        private void Start()
        {
            if (AutoStart)
            {
                StartDialog();
            }
        }

        public Fraza GetCurrentFraza() => _currentFraza; 
        public FrazaRazvilka GetCurrentFrazaRazvilka() => _currentFraza as FrazaRazvilka; 
        

        

        public void StartDialog() // ������ �������
        {
            _isCurrent = true; // ������ ������ �������������
            _dialogButtons.SetDialog (this);
            _dialogActivator.Activate(); // ����������� � ������ ����������, �� ����� ����������� ������ 
            _currentFraza = _firstFraza;
            Skazaty(); // �������������� �����, ���������� � ���� ���������
            OnStarted.Invoke();
        }

        public void NextFraza() //��������� ����� 
        {
            if (_isCurrent == false)
                return;             
            _currentFraza = _currentFraza.GetNextFraza();
            Skazaty();
        }

        private void Skazaty() // ��������� ��� ������ ������ ����� ��������, ���������� ����� 
        {

            if (_currentFraza != null)
            {
                _dialogviey.SetFraza(_currentFraza);
                CameraActivate();
                _beckgraunPereklychi.ActivateByIndex(_currentFraza.BackgroundIndex);
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(IsInputBack);
                CameraDiactivate();
                _beckgraunPereklychi.DiactivateAll();
                OnEnded.Invoke();
            }
        }

        private void CameraActivate()
        {
            if (_currentFraza.Camera == null)
                return;
            
            CameraDiactivate();
            _currentCamera = _currentFraza.Camera;
            _currentCamera.gameObject.SetActive(true);
        }

        private void CameraDiactivate()
        {
            if (_currentCamera != null)
            {
                _currentCamera.gameObject.SetActive(false);
            }
        }

       
    }

}