using UnityEngine;

public class DataManager : MonoBehaviour
{
    DataManager Instance;
    public MainManager mainManager;
    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveData(string playerName, string score)
    {
        UserData userData = new UserData();
        userData.PlayerName = playerName;
        userData.Score = score;

        string json = JsonUtility.ToJson(userData);

        Debug.Log(json);
    }
    public class UserData
    {
        public string PlayerName;
        public string Score;
    }
}
