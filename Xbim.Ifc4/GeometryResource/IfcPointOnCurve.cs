// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPointOnCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPointOnCurve : IIfcPoint
	{
		IIfcCurve @BasisCurve { get; }
		IfcParameterValue @PointParameter { get; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCPOINTONCURVE", 825)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPointOnCurve : IfcPoint, IInstantiableEntity, IIfcPointOnCurve, IEqualityComparer<@IfcPointOnCurve>, IEquatable<@IfcPointOnCurve>
	{
		#region IIfcPointOnCurve explicit implementation
		IIfcCurve IIfcPointOnCurve.BasisCurve { get { return @BasisCurve; } }	
		IfcParameterValue IIfcPointOnCurve.PointParameter { get { return @PointParameter; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPointOnCurve(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _basisCurve;
		private IfcParameterValue _pointParameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @BasisCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisCurve;
				((IPersistEntity)this).Activate(false);
				return _basisCurve;
			} 
			set
			{
				SetValue( v =>  _basisCurve = v, _basisCurve, value,  "BasisCurve");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @PointParameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pointParameter;
				((IPersistEntity)this).Activate(false);
				return _pointParameter;
			} 
			set
			{
				SetValue( v =>  _pointParameter = v, _pointParameter, value,  "PointParameter");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public override IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return BasisCurve.Dim;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisCurve = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_pointParameter = value.RealVal;
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
        public bool Equals(@IfcPointOnCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPointOnCurve
            var root = (@IfcPointOnCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPointOnCurve left, @IfcPointOnCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPointOnCurve left, @IfcPointOnCurve right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPointOnCurve x, @IfcPointOnCurve y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPointOnCurve obj)
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