using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public Text counterText;
    
    private int counter = 0;
    private bool isCounting = false;
    private Coroutine countingCoroutine;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isCounting) StopCounting();
            else StartCounting();
        }
        
        if (counterText != null)
            counterText.text = "Счетчик: " + counter;
    }

    void StartCounting()
    {
        isCounting = true;
        countingCoroutine = StartCoroutine(CountEveryHalfSecond());
        Debug.Log("Счетчик запущен");
    }

    void StopCounting()
    {
        isCounting = false;
        if (countingCoroutine != null)
        {
            StopCoroutine(countingCoroutine);
        }
        Debug.Log("Счетчик остановлен. Текущее значение: " + counter);
    }

    IEnumerator CountEveryHalfSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            counter++;
            Debug.Log("Счетчик: " + counter);
        }
    }
}