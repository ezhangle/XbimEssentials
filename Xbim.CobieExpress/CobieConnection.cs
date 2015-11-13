// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("CONNECTION", 26)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieConnection : CobieReferencedObject, IInstantiableEntity, IEqualityComparer<@CobieConnection>, IEquatable<@CobieConnection>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieConnection(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobiePickValue _connectionType;
		private CobieComponent _componentA;
		private CobieComponent _componentB;
		private CobieComponent _realizingComponent;
		private string _portNameA;
		private string _portNameB;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobiePickValue @ConnectionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _connectionType;
				((IPersistEntity)this).Activate(false);
				return _connectionType;
			} 
			set
			{
				SetValue( v =>  _connectionType = v, _connectionType, value,  "ConnectionType");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieComponent @ComponentA 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _componentA;
				((IPersistEntity)this).Activate(false);
				return _componentA;
			} 
			set
			{
				SetValue( v =>  _componentA = v, _componentA, value,  "ComponentA");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieComponent @ComponentB 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _componentB;
				((IPersistEntity)this).Activate(false);
				return _componentB;
			} 
			set
			{
				SetValue( v =>  _componentB = v, _componentB, value,  "ComponentB");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieComponent @RealizingComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _realizingComponent;
				((IPersistEntity)this).Activate(false);
				return _realizingComponent;
			} 
			set
			{
				SetValue( v =>  _realizingComponent = v, _realizingComponent, value,  "RealizingComponent");
			} 
		}
	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @PortNameA 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _portNameA;
				((IPersistEntity)this).Activate(false);
				return _portNameA;
			} 
			set
			{
				SetValue( v =>  _portNameA = v, _portNameA, value,  "PortNameA");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @PortNameB 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _portNameB;
				((IPersistEntity)this).Activate(false);
				return _portNameB;
			} 
			set
			{
				SetValue( v =>  _portNameB = v, _portNameB, value,  "PortNameB");
			} 
		}
	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_name = value.StringVal;
					return;
				case 5: 
					_description = value.StringVal;
					return;
				case 6: 
					_connectionType = (CobiePickValue)(value.EntityVal);
					return;
				case 7: 
					_componentA = (CobieComponent)(value.EntityVal);
					return;
				case 8: 
					_componentB = (CobieComponent)(value.EntityVal);
					return;
				case 9: 
					_realizingComponent = (CobieComponent)(value.EntityVal);
					return;
				case 10: 
					_portNameA = value.StringVal;
					return;
				case 11: 
					_portNameB = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieConnection other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieConnection
            var root = (@CobieConnection)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieConnection left, @CobieConnection right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieConnection left, @CobieConnection right)
        {
            return !(left == right);
        }


        public bool Equals(@CobieConnection x, @CobieConnection y)
        {
            return x == y;
        }

        public int GetHashCode(@CobieConnection obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}