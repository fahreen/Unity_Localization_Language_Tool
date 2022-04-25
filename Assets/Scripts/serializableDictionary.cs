using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class serializableDictionary
{
    public List<string> keyList;
    public List<string> valueList;

    //constructor
    public serializableDictionary()
    {
        keyList = new List<string>();
        valueList = new List<string>();
    }

    public void AddElement(string x, string y)
    {
        
        keyList.Add(x);
        valueList.Add(y);
    }

    public bool removeElement(string x)
    {
        for (int i = 0; i < keyList.Count; i++)
        {
            if (keyList[i] == x)
            {
                keyList.RemoveAt(i);
                valueList.RemoveAt(i);

                return true;
            }
        }
        return false;
    }

    public string GetValue(string k)
    {
        for (int i = 0; i < keyList.Count; i++)
        {
            if (keyList[i] == k)
            {
                return valueList[i];
            }
        }
        return null;

    }

    public void empty()
    {
        keyList.Clear();
        valueList.Clear();
    }


    public void SeeValues()
    {
        for (int i = 0; i < keyList.Count; i++)
        {
            Debug.Log("keys: " + keyList[i]);
        }


        for (int i = 0; i < valueList.Count; i++)
        {
            Debug.Log("VALUES: " + valueList[i]);
        }
    }


    public bool SetValue(string k, string v)
    {
        for (int i = 0; i < keyList.Count; i++)
        {
            if (keyList[i] == k)
            {
                valueList[i] = v;
                return true;
            }
        }
        return false;

    }





}

