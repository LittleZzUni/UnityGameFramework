﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    internal sealed class PlaySoundInfo : IReference
    {
        private Entity m_BindingEntity;
        private Vector3 m_WorldPosition;
        private object m_UserData;

        public PlaySoundInfo()
        {
            m_BindingEntity = null;
            m_WorldPosition = Vector3.zero;
            m_UserData = null;
        }

        public Entity BindingEntity
        {
            get
            {
                return m_BindingEntity;
            }
        }

        public Vector3 WorldPosition
        {
            get
            {
                return m_WorldPosition;
            }
        }

        public object UserData
        {
            get
            {
                return m_UserData;
            }
        }

        public void Initialize(Entity bindingEntity, Vector3 worldPosition, object userData)
        {
            m_BindingEntity = bindingEntity;
            m_WorldPosition = worldPosition;
            m_UserData = userData;
        }

        public void Clear()
        {
            m_BindingEntity = null;
            m_WorldPosition = Vector3.zero;
            m_UserData = null;
        }
    }
}
