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
using Xbim.Ifc2x3.ConstructionMgmtDomain;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLaborResource
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLaborResource : IIfcConstructionResource
	{
		IfcText? @SkillSet { get; }
	
	}
}

namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	[ExpressType("IFCLABORRESOURCE", 156)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLaborResource : IfcConstructionResource, IInstantiableEntity, IIfcLaborResource, IEqualityComparer<@IfcLaborResource>, IEquatable<@IfcLaborResource>
	{
		#region IIfcLaborResource explicit implementation
		IfcText? IIfcLaborResource.SkillSet { get { return @SkillSet; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLaborResource(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcText? _skillSet;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @SkillSet 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _skillSet;
				((IPersistEntity)this).Activate(false);
				return _skillSet;
			} 
			set
			{
				SetValue( v =>  _skillSet = v, _skillSet, value,  "SkillSet");
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
					_skillSet = value.StringVal;
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
        public bool Equals(@IfcLaborResource other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLaborResource
            var root = (@IfcLaborResource)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLaborResource left, @IfcLaborResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLaborResource left, @IfcLaborResource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLaborResource x, @IfcLaborResource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLaborResource obj)
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