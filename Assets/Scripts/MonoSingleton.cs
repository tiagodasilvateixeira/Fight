﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError($"{typeof(T).ToString()} is null");

                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance == null)
                _instance = (T)this;
        }
    }
}