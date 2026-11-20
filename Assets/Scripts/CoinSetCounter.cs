using UnityEngine;
using TMPro;

public class CoinSetCounter : MonoBehaviour
{
    public TMP_Text coinSetText;
    private int count = 0;

    public void CollectCoinSet()
    {
        count++;
        coinSetText.text = "CoinSet: x" + count;
    }
}