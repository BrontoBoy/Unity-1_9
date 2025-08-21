using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int LeftMouseButton = 0;
    
    public event System.Action OnLeftMouseButtonPressed;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            OnLeftMouseButtonPressed?.Invoke();
        }
    }
}
