using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_STAFF_NPOI_ALL")]
	public partial class CauseObject_V_HEM_STAFF_NPOI_ALL:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
        System.Int32 _ROWEND = ConstLibrary.Template.UndefineInt;
		
		public System.Int32  ROWEND{get{ return  _ROWEND;}set{ _ROWEND = value;}}
        System.Int32 _CELLEND = ConstLibrary.Template.UndefineInt;
		
		public System.Int32  CELLEND{get{ return  _CELLEND;}set{ _CELLEND = value;}}
		System.Int32 _ROWSTART = ConstLibrary.Template.UndefineInt;
		
		public System.Int32  ROWSTART{get{ return  _ROWSTART;}set{ _ROWSTART = value;}}
        System.Int32 _CELLSTART = ConstLibrary.Template.UndefineInt;
		
		public System.Int32  CELLSTART{get{ return  _CELLSTART;}set{ _CELLSTART = value;}}
		System.String _HEADERNAME = string.Empty;
		
		public System.String  HEADERNAME{get{ return  _HEADERNAME;}set{ _HEADERNAME = value;}}
        System.Int32 _NUM = ConstLibrary.Template.UndefineInt;
		
		public System.Int32  NUM{get{ return  _NUM;}set{ _NUM = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_STAFF_NPOI_ALL:EntityObject_V_HEM_STAFF_NPOI_ALL
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_STAFF_NPOI_ALL:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Int32  _ROWEND;
		
		public System.Int32  ROWEND{get{ return  _ROWEND;}set{ _ROWEND = value;}}
		System.Int32  _CELLEND;
		
		public System.Int32  CELLEND{get{ return  _CELLEND;}set{ _CELLEND = value;}}
		System.Int32  _ROWSTART;
		
		public System.Int32  ROWSTART{get{ return  _ROWSTART;}set{ _ROWSTART = value;}}
		System.Int32  _CELLSTART;
		
		public System.Int32  CELLSTART{get{ return  _CELLSTART;}set{ _CELLSTART = value;}}
		System.String  _HEADERNAME;
		
		public System.String  HEADERNAME{get{ return  _HEADERNAME;}set{ _HEADERNAME = value;}}
		System.Int32  _NUM;
		
		public System.Int32  NUM{get{ return  _NUM;}set{ _NUM = value;}}

		#endregion 
	}	
}
