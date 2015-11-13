// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTransportElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTransportElement : IIfcElement
	{
		IfcTransportElementTypeEnum? @OperationType { get; }
		IfcMassMeasure? @CapacityByWeight { get; }
		IfcCountMeasure? @CapacityByNumber { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IFCTRANSPORTELEMENT", 416)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTransportElement : IfcElement, IInstantiableEntity, IIfcTransportElement, IEqualityComparer<@IfcTransportElement>, IEquatable<@IfcTransportElement>
	{
		#region IIfcTransportElement explicit implementation
		IfcTransportElementTypeEnum? IIfcTransportElement.OperationType { get { return @OperationType; } }	
		IfcMassMeasure? IIfcTransportElement.CapacityByWeight { get { return @CapacityByWeight; } }	
		IfcCountMeasure? IIfcTransportElement.CapacityByNumber { get { return @CapacityByNumber; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTransportElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTransportElementTypeEnum? _operationType;
		private IfcMassMeasure? _capacityByWeight;
		private IfcCountMeasure? _capacityByNumber;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTransportElementTypeEnum? @OperationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operationType;
				((IPersistEntity)this).Activate(false);
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMassMeasure? @CapacityByWeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _capacityByWeight;
				((IPersistEntity)this).Activate(false);
				return _capacityByWeight;
			} 
			set
			{
				SetValue( v =>  _capacityByWeight = v, _capacityByWeight, value,  "CapacityByWeight");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCountMeasure? @CapacityByNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _capacityByNumber;
				((IPersistEntity)this).Activate(false);
				return _capacityByNumber;
			} 
			set
			{
				SetValue( v =>  _capacityByNumber = v, _capacityByNumber, value,  "CapacityByNumber");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _operationType = (IfcTransportElementTypeEnum) System.Enum.Parse(typeof (IfcTransportElementTypeEnum), value.EnumVal, true);
					return;
				case 9: 
					_capacityByWeight = value.RealVal;
					return;
				case 10: 
					_capacityByNumber = value.NumberVal;
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
        public bool Equals(@IfcTransportElement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTransportElement
            var root = (@IfcTransportElement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTransportElement left, @IfcTransportElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTransportElement left, @IfcTransportElement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTransportElement x, @IfcTransportElement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTransportElement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}