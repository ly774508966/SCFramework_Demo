//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using SCFramework;

namespace Game.Demo
{
    public partial class TDItem
    {
      
        private string m_Id;
        private string m_ItemName;
        private string m_ItemDes;
        private EInt m_Rare = 0;
        private EInt m_Level = 0;
        private EInt m_Type = 0;
        private EInt m_StackNum = 0;
        private EInt m_NumMax = 0;
        private EInt m_UsedType = 0;
        private EInt m_CDGroup = 0;
        private EInt m_CDTime = 0;
        private bool m_BatchUse = false;
        private EInt m_UseLvRequest = 0;
        private string m_UseHeroRequest;
        private string m_UseItemRequest;
        private EInt m_NumType = 0;
        private EInt m_DropBox = 0;
        private EInt m_DropNumType = 0;
        private EInt m_DropNum = 0;
        private EInt m_Bind = 0;
        private EInt m_BindItemId = 0;
        private EInt m_GroupId = 0;
        private EInt m_TradeLockTime = 0;
        private EInt m_SellType = 0;
        private EInt m_SellValue = 0;
        private EInt m_Label = 0;
        private string m_Function;
        private string m_ItemIcon;
        private EInt m_TimeDeadLine = 0;
        private EInt m_LootId = 0;
        private string m_Script;
        private string m_LuaScript;
        private string m_FlowID;
      
      private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// 道具ID
        /// </summary>
        public string id {get { return m_Id; } }
      
        /// <summary>
        /// 道具名字
        /// </summary>
        public string itemName {get { return m_ItemName; } }
      
        /// <summary>
        /// 道具描述
        /// </summary>
        public string itemDes {get { return m_ItemDes; } }
      
        /// <summary>
        /// 道具品质
        /// </summary>
        public int rare {get { return m_Rare; } }
      
        /// <summary>
        /// 道具等级
        /// </summary>
        public int level {get { return m_Level; } }
      
        /// <summary>
        /// 道具类型
        /// </summary>
        public int type {get { return m_Type; } }
      
        /// <summary>
        /// 叠加数量
        /// </summary>
        public int stackNum {get { return m_StackNum; } }
      
        /// <summary>
        /// 可拥有数量上限
        /// </summary>
        public int numMax {get { return m_NumMax; } }
      
        /// <summary>
        /// 使用类型
        /// </summary>
        public int usedType {get { return m_UsedType; } }
      
        /// <summary>
        /// CD组
        /// </summary>
        public int cDGroup {get { return m_CDGroup; } }
      
        /// <summary>
        /// 使用冷却时间
        /// </summary>
        public int cDTime {get { return m_CDTime; } }
      
        /// <summary>
        /// 是否可批量使用
        /// </summary>
        public bool batchUse {get { return m_BatchUse; } }
      
        /// <summary>
        /// 使用等级限制
        /// </summary>
        public int useLvRequest {get { return m_UseLvRequest; } }
      
        /// <summary>
        /// 使用英雄限制
        /// </summary>
        public string useHeroRequest {get { return m_UseHeroRequest; } }
      
        /// <summary>
        /// 使用需要道具
        /// </summary>
        public string useItemRequest {get { return m_UseItemRequest; } }
      
        /// <summary>
        /// 程序用数值类型
        /// </summary>
        public int numType {get { return m_NumType; } }
      
        /// <summary>
        /// 掉落库
        /// </summary>
        public int dropBox {get { return m_DropBox; } }
      
        /// <summary>
        /// 数值类型
        /// </summary>
        public int dropNumType {get { return m_DropNumType; } }
      
        /// <summary>
        /// 数值
        /// </summary>
        public int dropNum {get { return m_DropNum; } }
      
        /// <summary>
        /// 是否绑定
        /// </summary>
        public int bind {get { return m_Bind; } }
      
        /// <summary>
        /// 绑定道具ID
        /// </summary>
        public int bindItemId {get { return m_BindItemId; } }
      
        /// <summary>
        /// 组ID
        /// </summary>
        public int groupId {get { return m_GroupId; } }
      
        /// <summary>
        /// 交易锁定时间
        /// </summary>
        public int tradeLockTime {get { return m_TradeLockTime; } }
      
        /// <summary>
        /// 货币种类
        /// </summary>
        public int sellType {get { return m_SellType; } }
      
        /// <summary>
        /// 出售价格
        /// </summary>
        public int sellValue {get { return m_SellValue; } }
      
        /// <summary>
        /// 背包标签
        /// </summary>
        public int label {get { return m_Label; } }
      
        /// <summary>
        /// 道具功能
        /// </summary>
        public string function {get { return m_Function; } }
      
        /// <summary>
        /// 道具Icon
        /// </summary>
        public string itemIcon {get { return m_ItemIcon; } }
      
        /// <summary>
        /// 道具有效时间
        /// </summary>
        public int timeDeadLine {get { return m_TimeDeadLine; } }
      
        /// <summary>
        /// 掉落表现
        /// </summary>
        public int lootId {get { return m_LootId; } }
      
        /// <summary>
        /// 脚本
        /// </summary>
        public string script {get { return m_Script; } }
      
        /// <summary>
        /// Lua脚本
        /// </summary>
        public string luaScript {get { return m_LuaScript; } }
      
        /// <summary>
        /// 流程ID
        /// </summary>
        public string flowID {get { return m_FlowID; } }

        public void ReadRow(DataStreamReader dataR, int[] filedIndex)
        {
          var schemeNames = dataR.GetSchemeName();
          int col = 0;
          while(true)
          {
            col = dataR.MoreFieldOnRow();
            if (col == -1)
            {
              break;
            }
            switch (filedIndex[col])
            { 
                case 0:
                    m_Id = dataR.ReadString();
                    break;
                case 1:
                    m_ItemName = dataR.ReadString();
                    break;
                case 2:
                    m_ItemDes = dataR.ReadString();
                    break;
                case 3:
                    m_Rare = dataR.ReadInt();
                    break;
                case 4:
                    m_Level = dataR.ReadInt();
                    break;
                case 5:
                    m_Type = dataR.ReadInt();
                    break;
                case 6:
                    m_StackNum = dataR.ReadInt();
                    break;
                case 7:
                    m_NumMax = dataR.ReadInt();
                    break;
                case 8:
                    m_UsedType = dataR.ReadInt();
                    break;
                case 9:
                    m_CDGroup = dataR.ReadInt();
                    break;
                case 10:
                    m_CDTime = dataR.ReadInt();
                    break;
                case 11:
                    m_BatchUse = dataR.ReadBool();
                    break;
                case 12:
                    m_UseLvRequest = dataR.ReadInt();
                    break;
                case 13:
                    m_UseHeroRequest = dataR.ReadString();
                    break;
                case 14:
                    m_UseItemRequest = dataR.ReadString();
                    break;
                case 15:
                    m_NumType = dataR.ReadInt();
                    break;
                case 16:
                    m_DropBox = dataR.ReadInt();
                    break;
                case 17:
                    m_DropNumType = dataR.ReadInt();
                    break;
                case 18:
                    m_DropNum = dataR.ReadInt();
                    break;
                case 19:
                    m_Bind = dataR.ReadInt();
                    break;
                case 20:
                    m_BindItemId = dataR.ReadInt();
                    break;
                case 21:
                    m_GroupId = dataR.ReadInt();
                    break;
                case 22:
                    m_TradeLockTime = dataR.ReadInt();
                    break;
                case 23:
                    m_SellType = dataR.ReadInt();
                    break;
                case 24:
                    m_SellValue = dataR.ReadInt();
                    break;
                case 25:
                    m_Label = dataR.ReadInt();
                    break;
                case 26:
                    m_Function = dataR.ReadString();
                    break;
                case 27:
                    m_ItemIcon = dataR.ReadString();
                    break;
                case 28:
                    m_TimeDeadLine = dataR.ReadInt();
                    break;
                case 29:
                    m_LootId = dataR.ReadInt();
                    break;
                case 30:
                    m_Script = dataR.ReadString();
                    break;
                case 31:
                    m_LuaScript = dataR.ReadString();
                    break;
                case 32:
                    m_FlowID = dataR.ReadString();
                    break;
                default:
                    TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public DataStreamReader.FieldType GetFieldTypeInNew(string fieldName)
        {
            if (m_DataCacheNoGenerate.ContainsKey(fieldName))
            {
                return m_DataCacheNoGenerate[fieldName].fieldType;
            }
            return DataStreamReader.FieldType.Unkown;
        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(33);
          
          ret.Add("Id", 0);
          ret.Add("ItemName", 1);
          ret.Add("ItemDes", 2);
          ret.Add("Rare", 3);
          ret.Add("Level", 4);
          ret.Add("Type", 5);
          ret.Add("StackNum", 6);
          ret.Add("NumMax", 7);
          ret.Add("UsedType", 8);
          ret.Add("CDGroup", 9);
          ret.Add("CDTime", 10);
          ret.Add("BatchUse", 11);
          ret.Add("UseLvRequest", 12);
          ret.Add("UseHeroRequest", 13);
          ret.Add("UseItemRequest", 14);
          ret.Add("NumType", 15);
          ret.Add("DropBox", 16);
          ret.Add("DropNumType", 17);
          ret.Add("DropNum", 18);
          ret.Add("Bind", 19);
          ret.Add("BindItemId", 20);
          ret.Add("GroupId", 21);
          ret.Add("TradeLockTime", 22);
          ret.Add("SellType", 23);
          ret.Add("SellValue", 24);
          ret.Add("Label", 25);
          ret.Add("Function", 26);
          ret.Add("ItemIcon", 27);
          ret.Add("TimeDeadLine", 28);
          ret.Add("LootId", 29);
          ret.Add("Script", 30);
          ret.Add("LuaScript", 31);
          ret.Add("FlowID", 32);
          return ret;
        }
        
        
    }
}//namespace LR