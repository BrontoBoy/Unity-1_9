using System.Collections;
using UnityEngine;

public class CounterLogic : MonoBehaviour
{
    [SerializeField] private float _countInterval = 0.5f;
    
    private bool _isCounting = false;
    private Coroutine _countingCoroutine;
    private WaitForSeconds _waitForInterval; 
    
    public int Counter { get; private set; } = 0;
    
    public event System.Action<int> OnCounterChanged;
    
    private void Awake()
    {
        _waitForInterval = new WaitForSeconds(_countInterval);
    }
    
    public void ToggleCounting()
    {
        if (_isCounting)
        {
            StopCounting();
        }
        else
        {
            StartCounting();
        }
    }
    
    private void StartCounting()
    {
        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);
        }
        
        _isCounting = true;
        _countingCoroutine = StartCoroutine(CountRoutine());
    }
    
    private void StopCounting()
    {
        _isCounting = false;
        
        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);
            _countingCoroutine = null;
        }
    }
    
    private IEnumerator CountRoutine()
    {
        while (_isCounting)
        {
            yield return _waitForInterval;
            Counter++;
            OnCounterChanged?.Invoke(Counter);
        }
    }
    
    private void OnDisable()
    {
        StopCounting();
    }
}