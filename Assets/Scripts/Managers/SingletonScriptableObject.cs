using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonScriptableObject<T>: ScriptableObject where T : ScriptableObject
{
   private static T _instance = null;
    public static T Instance
    {
        get
        {
            if ( _instance == null)
            {
                T[] result =  Resources.FindObjectsOfTypeAll<T>();
                if (result.Length == 0)
                {
                    Debug.Log("SingletonScriptableObject -> Instance -> results length is for type " + typeof(T).ToString()+ ".");
                    return null;
                }
                if (result.Length >1)
                {
                    Debug.Log("SingletonScriptableObject -> Instance -> results length is greater than 1 for type " + typeof(T).ToString() + ".");
                    return null;
                }
                _instance = result[0];


            }
            return _instance;
        }
    }

}
