using UnityEngine;

public class CounterController : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private CounterLogic _counterLogic;
    
    private void OnEnable()
    {
        _inputReader.OnLeftMouseButtonPressed += _counterLogic.ToggleCounting;
    }
    
    private void OnDisable()
    {
        _inputReader.OnLeftMouseButtonPressed -= _counterLogic.ToggleCounting;
    }
}
