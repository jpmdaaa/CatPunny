using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;




[Serializable]
class PlayerData
{
    
    public int money = Player.money;
    


}



public class GameControll : MonoBehaviour
{
    public static GameControll gameControll;
  
    private int objcomprados;
    public int money = Player.money;
    private int fases;
    private string filePath;



    // Use this for initialization



void Awake()
    {
      



        if (gameControll == null)
        {
            gameControll = this;
        }

        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        filePath = Application.persistentDataPath + "/playerInfo.dat";
        Debug.Log(filePath);
    }

   

  public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        PlayerData data = new PlayerData();
        data.money = money;
        bf.Serialize(file, data);
      
        file.Close();

    }

   public void Load()
    {
        if(File.Exists(filePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(filePath, FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            money = data.money;
           

        }
    }







}
