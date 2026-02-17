using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    void Start()
    {
        playerNameText.text = PlayerData.playerName;
    }
}
