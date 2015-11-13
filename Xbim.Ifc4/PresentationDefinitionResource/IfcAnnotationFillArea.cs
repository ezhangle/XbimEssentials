// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationDefinitionResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAnnotationFillArea
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAnnotationFillArea : IIfcGeometricRepresentationItem
	{
		IIfcCurve @OuterBoundary { get; }
		IEnumerable<IIfcCurve> @InnerBoundaries { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationDefinitionResource
{
	[ExpressType("IFCANNOTATIONFILLAREA", 415)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationFillArea : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcAnnotationFillArea, IEqualityComparer<@IfcAnnotationFillArea>, IEquatable<@IfcAnnotationFillArea>
	{
		#region IIfcAnnotationFillArea explicit implementation
		IIfcCurve IIfcAnnotationFillArea.OuterBoundary { get { return @OuterBoundary; } }	
		IEnumerable<IIfcCurve> IIfcAnnotationFillArea.InnerBoundaries { get { return @InnerBoundaries; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationFillArea(IModel model) : base(model) 		{ 
			Model = model; 
			_innerBoundaries = new OptionalItemSet<IfcCurve>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcCurve _outerBoundary;
		private OptionalItemSet<IfcCurve> _innerBoundaries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @OuterBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _outerBoundary;
				((IPersistEntity)this).Activate(false);
				return _outerBoundary;
			} 
			set
			{
				SetValue( v =>  _outerBoundary = v, _outerBoundary, value,  "OuterBoundary");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcCurve> @InnerBoundaries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _innerBoundaries;
				((IPersistEntity)this).Activate(false);
				return _innerBoundaries;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_outerBoundary = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					if (_innerBoundaries == null) _innerBoundaries = new OptionalItemSet<IfcCurve>( this );
					_innerBoundaries.InternalAdd((IfcCurve)value.EntityVal);
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
        public bool Equals(@IfcAnnotationFillArea other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAnnotationFillArea
            var root = (@IfcAnnotationFillArea)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAnnotationFillArea left, @IfcAnnotationFillArea right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAnnotationFillArea left, @IfcAnnotationFillArea right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAnnotationFillArea x, @IfcAnnotationFillArea y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAnnotationFillArea obj)
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