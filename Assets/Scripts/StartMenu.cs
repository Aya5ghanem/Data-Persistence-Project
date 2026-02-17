using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StartGame()
    {
        PlayerData.playerName = nameInput.text;
        SceneManager.LoadScene("main"); // اسم مشهد اللعبة
    }
}
