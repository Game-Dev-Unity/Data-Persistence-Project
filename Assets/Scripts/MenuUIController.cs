using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUIController : MonoBehaviour
{
    private TMP_InputField playerName;
    private DataManager dataManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerName = GetComponentInChildren<TMP_InputField>();
        dataManager = FindFirstObjectByType<DataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        dataManager.SaveData(playerName.text, "0");
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
