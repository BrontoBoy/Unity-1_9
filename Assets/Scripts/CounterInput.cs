using UnityEngine;

public class CounterInput : MonoBehaviour
{
    private const int LeftMouseButton = 0;
    
    [SerializeField] private CounterLogic _counterLogic;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            _counterLogic.ToggleCounting();
        }
    }
}
