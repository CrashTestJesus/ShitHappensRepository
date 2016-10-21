using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class HighScoresScript : MonoBehaviour {

    public GameManager manager;

    public List<int> scores = new List<int>();
    public List<string> names = new List<string>();

    public Text[] nameText;
    public Text[] scoreText;

    public savedata data;
    
    void Start()
    {
        Load();

        manager = GameManager.Instance;

        if (manager.playerScore > scores[0])
        {

            scores.Remove(0);
            names.RemoveAt(0);
            scores.Add(manager.playerScore);
            scores.Sort();
            if (scores.Count > 5)
            {
                scores.Remove(scores.Min());
            }
            names.Insert(scores.IndexOf(manager.playerScore), manager.playerName);           
        }
        for (int i = 0; i < 5; i++)
        {
            nameText[i].text = names[i]; 
            scoreText[i].text = scores[i].ToString();
        }
    } 
    public void Save()
    {
        if(!Directory.Exists(Application.dataPath + "/Saves"))
        {
            Directory.CreateDirectory(Application.dataPath + "/Saves");
        }

        BinaryFormatter bf = new BinaryFormatter();

        FileStream file = File.Create(Application.dataPath + "/Saves/SaveData.dat");

        CopySaveData();
        bf.Serialize(file, data);
    }
    public void CopySaveData()
    {
        data.scores.Clear();
        foreach(int i in scores)
        {
            data.scores.Add(i);
        }
        data.names.Clear();
        foreach(string s in names)
        {
            data.names.Add(s);
        }
    }
    public void Load()
    {
        if(File.Exists(Application.dataPath + "/Saves/SaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.dataPath + "/Saves/SaveData.dat", FileMode.Open);
            data = (savedata)bf.Deserialize(file);

            CopyLoadData();

            file.Close();
        }
    }
    public void CopyLoadData()
    {
        scores.Clear();
        foreach(int i in data.scores)
        {
            scores.Add(i);
        }
        names.Clear();
        foreach(string s in data.names)
        {
            names.Add(s);
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Save();
            SceneManager.LoadScene(0);
        }

    }
}
[System.Serializable]
public class savedata
{
   public List<int> scores = new List<int>();
    public List<string> names = new List<string>();
}
