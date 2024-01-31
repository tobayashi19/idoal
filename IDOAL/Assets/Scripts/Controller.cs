using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public TMP_Text currencyText;

    public double currency;

    public void Update()
    {
        currencyText.text = currency + "Currency";
    }

    public void GenerateCurrency()
    {
        currency += 1;
    }
}
