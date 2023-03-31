using System;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Core.Enums;

namespace Core.Tools
{
    [Serializable]
    public class DirectionalCameraPair 
    {
        [SerializeField] private CinemachineVirtualCamera _rightCamera;
        [SerializeField] private CinemachineVirtualCamera _leftCamera;

        private Dictionary<Direction, CinemachineVirtualCamera> _directionalCameras;

        public Dictionary<Direction, CinemachineVirtualCamera> DirectionalCameras
        {
            get
            {
                if(_directionalCameras != null)
                    return _directionalCameras;
                
                _directionalCameras = new Dictionary<Direction, CinemachineVirtualCamera>
                {
                    {Direction.Left, _leftCamera},
                    {Direction.Right, _rightCamera}
                };
                return _directionalCameras;
            }
        }
    }
}

