using UnityEngine;
using UnityEngine.UI;

public class CounterUI : MonoBehaviour
{
    [SerializeField] private CounterLogic _counterLogic;
    [SerializeField] private Text _counterText;
    
    private void OnEnable()
    {
        _counterLogic.OnCounterChanged += UpdateCounterText;
        UpdateCounterText(_counterLogic.Counter);
    }
    
    private void OnDisable()
    {
        _counterLogic.OnCounterChanged -= UpdateCounterText;
    }
    
    private void UpdateCounterText(int value)
    {
        _counterText.text = $"Счетчик: {value}";
    }
}