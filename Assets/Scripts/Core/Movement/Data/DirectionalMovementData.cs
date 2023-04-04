using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Enums;


namespace Core.Movement.Data
{
    [Serializable]
    public class DirectionalMovementData
    {
        
        [field: SerializeField] public float HorizontalSpeed { get; private set; }
        [field: SerializeField] public Direction Direction { get; private set; }  
        [field: SerializeField] public float VerticalSpeed { get; private set; }
        [field: SerializeField] public float MinSize { get; private set; }
        [field: SerializeField] public float MaxSize { get; private set; }
        [field: SerializeField] public float MaxVerticalPosition { get; private set; }
        [field: SerializeField] public float MinVerticalPosition { get; private set; }    
    }
}