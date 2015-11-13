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
using Xbim.Ifc2x3.ProfilePropertyResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralProfileProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralProfileProperties : IIfcGeneralProfileProperties
	{
		IfcMomentOfInertiaMeasure? @TorsionalConstantX { get; }
		IfcMomentOfInertiaMeasure? @MomentOfInertiaYZ { get; }
		IfcMomentOfInertiaMeasure? @MomentOfInertiaY { get; }
		IfcMomentOfInertiaMeasure? @MomentOfInertiaZ { get; }
		IfcWarpingConstantMeasure? @WarpingConstant { get; }
		IfcLengthMeasure? @ShearCentreZ { get; }
		IfcLengthMeasure? @ShearCentreY { get; }
		IfcAreaMeasure? @ShearDeformationAreaZ { get; }
		IfcAreaMeasure? @ShearDeformationAreaY { get; }
		IfcSectionModulusMeasure? @MaximumSectionModulusY { get; }
		IfcSectionModulusMeasure? @MinimumSectionModulusY { get; }
		IfcSectionModulusMeasure? @MaximumSectionModulusZ { get; }
		IfcSectionModulusMeasure? @MinimumSectionModulusZ { get; }
		IfcSectionModulusMeasure? @TorsionalSectionModulus { get; }
		IfcLengthMeasure? @CentreOfGravityInX { get; }
		IfcLengthMeasure? @CentreOfGravityInY { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IFCSTRUCTURALPROFILEPROPERTIES", 683)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralProfileProperties : IfcGeneralProfileProperties, IInstantiableEntity, IIfcStructuralProfileProperties, IEqualityComparer<@IfcStructuralProfileProperties>, IEquatable<@IfcStructuralProfileProperties>
	{
		#region IIfcStructuralProfileProperties explicit implementation
		IfcMomentOfInertiaMeasure? IIfcStructuralProfileProperties.TorsionalConstantX { get { return @TorsionalConstantX; } }	
		IfcMomentOfInertiaMeasure? IIfcStructuralProfileProperties.MomentOfInertiaYZ { get { return @MomentOfInertiaYZ; } }	
		IfcMomentOfInertiaMeasure? IIfcStructuralProfileProperties.MomentOfInertiaY { get { return @MomentOfInertiaY; } }	
		IfcMomentOfInertiaMeasure? IIfcStructuralProfileProperties.MomentOfInertiaZ { get { return @MomentOfInertiaZ; } }	
		IfcWarpingConstantMeasure? IIfcStructuralProfileProperties.WarpingConstant { get { return @WarpingConstant; } }	
		IfcLengthMeasure? IIfcStructuralProfileProperties.ShearCentreZ { get { return @ShearCentreZ; } }	
		IfcLengthMeasure? IIfcStructuralProfileProperties.ShearCentreY { get { return @ShearCentreY; } }	
		IfcAreaMeasure? IIfcStructuralProfileProperties.ShearDeformationAreaZ { get { return @ShearDeformationAreaZ; } }	
		IfcAreaMeasure? IIfcStructuralProfileProperties.ShearDeformationAreaY { get { return @ShearDeformationAreaY; } }	
		IfcSectionModulusMeasure? IIfcStructuralProfileProperties.MaximumSectionModulusY { get { return @MaximumSectionModulusY; } }	
		IfcSectionModulusMeasure? IIfcStructuralProfileProperties.MinimumSectionModulusY { get { return @MinimumSectionModulusY; } }	
		IfcSectionModulusMeasure? IIfcStructuralProfileProperties.MaximumSectionModulusZ { get { return @MaximumSectionModulusZ; } }	
		IfcSectionModulusMeasure? IIfcStructuralProfileProperties.MinimumSectionModulusZ { get { return @MinimumSectionModulusZ; } }	
		IfcSectionModulusMeasure? IIfcStructuralProfileProperties.TorsionalSectionModulus { get { return @TorsionalSectionModulus; } }	
		IfcLengthMeasure? IIfcStructuralProfileProperties.CentreOfGravityInX { get { return @CentreOfGravityInX; } }	
		IfcLengthMeasure? IIfcStructuralProfileProperties.CentreOfGravityInY { get { return @CentreOfGravityInY; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMomentOfInertiaMeasure? _torsionalConstantX;
		private IfcMomentOfInertiaMeasure? _momentOfInertiaYZ;
		private IfcMomentOfInertiaMeasure? _momentOfInertiaY;
		private IfcMomentOfInertiaMeasure? _momentOfInertiaZ;
		private IfcWarpingConstantMeasure? _warpingConstant;
		private IfcLengthMeasure? _shearCentreZ;
		private IfcLengthMeasure? _shearCentreY;
		private IfcAreaMeasure? _shearDeformationAreaZ;
		private IfcAreaMeasure? _shearDeformationAreaY;
		private IfcSectionModulusMeasure? _maximumSectionModulusY;
		private IfcSectionModulusMeasure? _minimumSectionModulusY;
		private IfcSectionModulusMeasure? _maximumSectionModulusZ;
		private IfcSectionModulusMeasure? _minimumSectionModulusZ;
		private IfcSectionModulusMeasure? _torsionalSectionModulus;
		private IfcLengthMeasure? _centreOfGravityInX;
		private IfcLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @TorsionalConstantX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _torsionalConstantX;
				((IPersistEntity)this).Activate(false);
				return _torsionalConstantX;
			} 
			set
			{
				SetValue( v =>  _torsionalConstantX = v, _torsionalConstantX, value,  "TorsionalConstantX");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @MomentOfInertiaYZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _momentOfInertiaYZ;
				((IPersistEntity)this).Activate(false);
				return _momentOfInertiaYZ;
			} 
			set
			{
				SetValue( v =>  _momentOfInertiaYZ = v, _momentOfInertiaYZ, value,  "MomentOfInertiaYZ");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @MomentOfInertiaY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _momentOfInertiaY;
				((IPersistEntity)this).Activate(false);
				return _momentOfInertiaY;
			} 
			set
			{
				SetValue( v =>  _momentOfInertiaY = v, _momentOfInertiaY, value,  "MomentOfInertiaY");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcMomentOfInertiaMeasure? @MomentOfInertiaZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _momentOfInertiaZ;
				((IPersistEntity)this).Activate(false);
				return _momentOfInertiaZ;
			} 
			set
			{
				SetValue( v =>  _momentOfInertiaZ = v, _momentOfInertiaZ, value,  "MomentOfInertiaZ");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcWarpingConstantMeasure? @WarpingConstant 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _warpingConstant;
				((IPersistEntity)this).Activate(false);
				return _warpingConstant;
			} 
			set
			{
				SetValue( v =>  _warpingConstant = v, _warpingConstant, value,  "WarpingConstant");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ShearCentreZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shearCentreZ;
				((IPersistEntity)this).Activate(false);
				return _shearCentreZ;
			} 
			set
			{
				SetValue( v =>  _shearCentreZ = v, _shearCentreZ, value,  "ShearCentreZ");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ShearCentreY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shearCentreY;
				((IPersistEntity)this).Activate(false);
				return _shearCentreY;
			} 
			set
			{
				SetValue( v =>  _shearCentreY = v, _shearCentreY, value,  "ShearCentreY");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @ShearDeformationAreaZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shearDeformationAreaZ;
				((IPersistEntity)this).Activate(false);
				return _shearDeformationAreaZ;
			} 
			set
			{
				SetValue( v =>  _shearDeformationAreaZ = v, _shearDeformationAreaZ, value,  "ShearDeformationAreaZ");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @ShearDeformationAreaY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shearDeformationAreaY;
				((IPersistEntity)this).Activate(false);
				return _shearDeformationAreaY;
			} 
			set
			{
				SetValue( v =>  _shearDeformationAreaY = v, _shearDeformationAreaY, value,  "ShearDeformationAreaY");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MaximumSectionModulusY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _maximumSectionModulusY;
				((IPersistEntity)this).Activate(false);
				return _maximumSectionModulusY;
			} 
			set
			{
				SetValue( v =>  _maximumSectionModulusY = v, _maximumSectionModulusY, value,  "MaximumSectionModulusY");
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MinimumSectionModulusY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _minimumSectionModulusY;
				((IPersistEntity)this).Activate(false);
				return _minimumSectionModulusY;
			} 
			set
			{
				SetValue( v =>  _minimumSectionModulusY = v, _minimumSectionModulusY, value,  "MinimumSectionModulusY");
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MaximumSectionModulusZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _maximumSectionModulusZ;
				((IPersistEntity)this).Activate(false);
				return _maximumSectionModulusZ;
			} 
			set
			{
				SetValue( v =>  _maximumSectionModulusZ = v, _maximumSectionModulusZ, value,  "MaximumSectionModulusZ");
			} 
		}	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @MinimumSectionModulusZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _minimumSectionModulusZ;
				((IPersistEntity)this).Activate(false);
				return _minimumSectionModulusZ;
			} 
			set
			{
				SetValue( v =>  _minimumSectionModulusZ = v, _minimumSectionModulusZ, value,  "MinimumSectionModulusZ");
			} 
		}	
		[EntityAttribute(21, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSectionModulusMeasure? @TorsionalSectionModulus 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _torsionalSectionModulus;
				((IPersistEntity)this).Activate(false);
				return _torsionalSectionModulus;
			} 
			set
			{
				SetValue( v =>  _torsionalSectionModulus = v, _torsionalSectionModulus, value,  "TorsionalSectionModulus");
			} 
		}	
		[EntityAttribute(22, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @CentreOfGravityInX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInX;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInX;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInX = v, _centreOfGravityInX, value,  "CentreOfGravityInX");
			} 
		}	
		[EntityAttribute(23, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInY;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_torsionalConstantX = value.RealVal;
					return;
				case 8: 
					_momentOfInertiaYZ = value.RealVal;
					return;
				case 9: 
					_momentOfInertiaY = value.RealVal;
					return;
				case 10: 
					_momentOfInertiaZ = value.RealVal;
					return;
				case 11: 
					_warpingConstant = value.RealVal;
					return;
				case 12: 
					_shearCentreZ = value.RealVal;
					return;
				case 13: 
					_shearCentreY = value.RealVal;
					return;
				case 14: 
					_shearDeformationAreaZ = value.RealVal;
					return;
				case 15: 
					_shearDeformationAreaY = value.RealVal;
					return;
				case 16: 
					_maximumSectionModulusY = value.RealVal;
					return;
				case 17: 
					_minimumSectionModulusY = value.RealVal;
					return;
				case 18: 
					_maximumSectionModulusZ = value.RealVal;
					return;
				case 19: 
					_minimumSectionModulusZ = value.RealVal;
					return;
				case 20: 
					_torsionalSectionModulus = value.RealVal;
					return;
				case 21: 
					_centreOfGravityInX = value.RealVal;
					return;
				case 22: 
					_centreOfGravityInY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : NOT(EXISTS(ShearDeformationAreaY)) OR (ShearDeformationAreaY >= 0.);*/
		/*WR22:	WR22 : NOT(EXISTS(ShearDeformationAreaZ)) OR (ShearDeformationAreaZ >= 0.);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralProfileProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralProfileProperties
            var root = (@IfcStructuralProfileProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralProfileProperties left, @IfcStructuralProfileProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralProfileProperties left, @IfcStructuralProfileProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralProfileProperties x, @IfcStructuralProfileProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralProfileProperties obj)
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