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
using Xbim.Ifc2x3.StructuralElementsDomain;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTendon
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTendon : IIfcReinforcingElement
	{
		IfcTendonTypeEnum @PredefinedType { get; }
		IfcPositiveLengthMeasure @NominalDiameter { get; }
		IfcAreaMeasure @CrossSectionArea { get; }
		IfcForceMeasure? @TensionForce { get; }
		IfcPressureMeasure? @PreStress { get; }
		IfcNormalisedRatioMeasure? @FrictionCoefficient { get; }
		IfcPositiveLengthMeasure? @AnchorageSlip { get; }
		IfcPositiveLengthMeasure? @MinCurvatureRadius { get; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	[ExpressType("IFCTENDON", 261)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTendon : IfcReinforcingElement, IInstantiableEntity, IIfcTendon, IEqualityComparer<@IfcTendon>, IEquatable<@IfcTendon>
	{
		#region IIfcTendon explicit implementation
		IfcTendonTypeEnum IIfcTendon.PredefinedType { get { return @PredefinedType; } }	
		IfcPositiveLengthMeasure IIfcTendon.NominalDiameter { get { return @NominalDiameter; } }	
		IfcAreaMeasure IIfcTendon.CrossSectionArea { get { return @CrossSectionArea; } }	
		IfcForceMeasure? IIfcTendon.TensionForce { get { return @TensionForce; } }	
		IfcPressureMeasure? IIfcTendon.PreStress { get { return @PreStress; } }	
		IfcNormalisedRatioMeasure? IIfcTendon.FrictionCoefficient { get { return @FrictionCoefficient; } }	
		IfcPositiveLengthMeasure? IIfcTendon.AnchorageSlip { get { return @AnchorageSlip; } }	
		IfcPositiveLengthMeasure? IIfcTendon.MinCurvatureRadius { get { return @MinCurvatureRadius; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTendon(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTendonTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure _nominalDiameter;
		private IfcAreaMeasure _crossSectionArea;
		private IfcForceMeasure? _tensionForce;
		private IfcPressureMeasure? _preStress;
		private IfcNormalisedRatioMeasure? _frictionCoefficient;
		private IfcPositiveLengthMeasure? _anchorageSlip;
		private IfcPositiveLengthMeasure? _minCurvatureRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTendonTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @NominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _nominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure @CrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcForceMeasure? @TensionForce 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tensionForce;
				((IPersistEntity)this).Activate(false);
				return _tensionForce;
			} 
			set
			{
				SetValue( v =>  _tensionForce = v, _tensionForce, value,  "TensionForce");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPressureMeasure? @PreStress 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _preStress;
				((IPersistEntity)this).Activate(false);
				return _preStress;
			} 
			set
			{
				SetValue( v =>  _preStress = v, _preStress, value,  "PreStress");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @FrictionCoefficient 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frictionCoefficient;
				((IPersistEntity)this).Activate(false);
				return _frictionCoefficient;
			} 
			set
			{
				SetValue( v =>  _frictionCoefficient = v, _frictionCoefficient, value,  "FrictionCoefficient");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @AnchorageSlip 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _anchorageSlip;
				((IPersistEntity)this).Activate(false);
				return _anchorageSlip;
			} 
			set
			{
				SetValue( v =>  _anchorageSlip = v, _anchorageSlip, value,  "AnchorageSlip");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MinCurvatureRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _minCurvatureRadius;
				((IPersistEntity)this).Activate(false);
				return _minCurvatureRadius;
			} 
			set
			{
				SetValue( v =>  _minCurvatureRadius = v, _minCurvatureRadius, value,  "MinCurvatureRadius");
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
                    _predefinedType = (IfcTendonTypeEnum) System.Enum.Parse(typeof (IfcTendonTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_nominalDiameter = value.RealVal;
					return;
				case 11: 
					_crossSectionArea = value.RealVal;
					return;
				case 12: 
					_tensionForce = value.RealVal;
					return;
				case 13: 
					_preStress = value.RealVal;
					return;
				case 14: 
					_frictionCoefficient = value.RealVal;
					return;
				case 15: 
					_anchorageSlip = value.RealVal;
					return;
				case 16: 
					_minCurvatureRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : (PredefinedType <> IfcTendonTypeEnum.USERDEFINED) OR ((PredefinedType = IfcTendonTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTendon other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTendon
            var root = (@IfcTendon)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTendon left, @IfcTendon right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTendon left, @IfcTendon right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTendon x, @IfcTendon y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTendon obj)
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