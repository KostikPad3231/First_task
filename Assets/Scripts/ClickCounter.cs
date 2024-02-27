using TMPro;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    private int _counter = 0;
    private TMP_Text counterText;

    private void Start()
    {
        counterText = GetComponentInChildren<TMP_Text>();
    }

    public void ClickCount()
    {
        ++_counter;
        counterText.text = _counter.ToString();
    }
}