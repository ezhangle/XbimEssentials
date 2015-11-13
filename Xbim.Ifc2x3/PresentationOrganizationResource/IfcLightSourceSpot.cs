// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationOrganizationResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightSourceSpot
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightSourceSpot : IIfcLightSourcePositional
	{
		IIfcDirection @Orientation { get; }
		IfcReal? @ConcentrationExponent { get; }
		IfcPositivePlaneAngleMeasure @SpreadAngle { get; }
		IfcPositivePlaneAngleMeasure @BeamWidthAngle { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[ExpressType("IFCLIGHTSOURCESPOT", 760)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourceSpot : IfcLightSourcePositional, IInstantiableEntity, IIfcLightSourceSpot, IEqualityComparer<@IfcLightSourceSpot>, IEquatable<@IfcLightSourceSpot>
	{
		#region IIfcLightSourceSpot explicit implementation
		IIfcDirection IIfcLightSourceSpot.Orientation { get { return @Orientation; } }	
		IfcReal? IIfcLightSourceSpot.ConcentrationExponent { get { return @ConcentrationExponent; } }	
		IfcPositivePlaneAngleMeasure IIfcLightSourceSpot.SpreadAngle { get { return @SpreadAngle; } }	
		IfcPositivePlaneAngleMeasure IIfcLightSourceSpot.BeamWidthAngle { get { return @BeamWidthAngle; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceSpot(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _orientation;
		private IfcReal? _concentrationExponent;
		private IfcPositivePlaneAngleMeasure _spreadAngle;
		private IfcPositivePlaneAngleMeasure _beamWidthAngle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @Orientation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _orientation;
				((IPersistEntity)this).Activate(false);
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @ConcentrationExponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _concentrationExponent;
				((IPersistEntity)this).Activate(false);
				return _concentrationExponent;
			} 
			set
			{
				SetValue( v =>  _concentrationExponent = v, _concentrationExponent, value,  "ConcentrationExponent");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositivePlaneAngleMeasure @SpreadAngle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _spreadAngle;
				((IPersistEntity)this).Activate(false);
				return _spreadAngle;
			} 
			set
			{
				SetValue( v =>  _spreadAngle = v, _spreadAngle, value,  "SpreadAngle");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositivePlaneAngleMeasure @BeamWidthAngle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _beamWidthAngle;
				((IPersistEntity)this).Activate(false);
				return _beamWidthAngle;
			} 
			set
			{
				SetValue( v =>  _beamWidthAngle = v, _beamWidthAngle, value,  "BeamWidthAngle");
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
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_orientation = (IfcDirection)(value.EntityVal);
					return;
				case 10: 
					_concentrationExponent = value.RealVal;
					return;
				case 11: 
					_spreadAngle = value.RealVal;
					return;
				case 12: 
					_beamWidthAngle = value.RealVal;
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
        public bool Equals(@IfcLightSourceSpot other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLightSourceSpot
            var root = (@IfcLightSourceSpot)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLightSourceSpot left, @IfcLightSourceSpot right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLightSourceSpot left, @IfcLightSourceSpot right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLightSourceSpot x, @IfcLightSourceSpot y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLightSourceSpot obj)
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