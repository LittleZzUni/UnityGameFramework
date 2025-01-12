﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using GameFramework.Event;
using System;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 加载数据表失败事件。
    /// </summary>
    public sealed class LoadDataTableFailureEventArgs : GameEventArgs
    {
        /// <summary>
        /// 加载数据表失败事件编号。
        /// </summary>
        public static readonly int EventId = typeof(LoadDataTableFailureEventArgs).GetHashCode();

        /// <summary>
        /// 获取加载数据表失败事件编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 获取数据表行的类型。
        /// </summary>
        public Type DataRowType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取数据表名称。
        /// </summary>
        public string DataTableName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取数据表资源名称。
        /// </summary>
        public string DataTableAssetName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取数据表加载方式。
        /// </summary>
        public LoadType LoadType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取错误信息。
        /// </summary>
        public string ErrorMessage
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }

        /// <summary>
        /// 清理加载数据表失败事件。
        /// </summary>
        public override void Clear()
        {
            DataRowType = default(Type);
            DataTableName = default(string);
            DataTableAssetName = default(string);
            LoadType = default(LoadType);
            ErrorMessage = default(string);
            UserData = default(object);
        }

        /// <summary>
        /// 填充加载数据表失败事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>加载数据表失败事件。</returns>
        public LoadDataTableFailureEventArgs Fill(GameFramework.DataTable.LoadDataTableFailureEventArgs e)
        {
            LoadDataTableInfo loadDataTableInfo = (LoadDataTableInfo)e.UserData;
            DataRowType = loadDataTableInfo.DataRowType;
            DataTableName = loadDataTableInfo.DataTableName;
            DataTableAssetName = e.DataTableAssetName;
            LoadType = e.LoadType;
            ErrorMessage = e.ErrorMessage;
            UserData = loadDataTableInfo.UserData;

            ReferencePool.Release(loadDataTableInfo);
            return this;
        }
    }
}
