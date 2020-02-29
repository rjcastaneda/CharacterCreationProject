using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicObject : MonoBehaviour
{
    //Singleton
    private static MusicObject _instance;
    public static MusicObject Instance
    {
        get { return _instance; }
    }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
