// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.FacilitiesMgmtDomain;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcActionRequest
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcActionRequest : IIfcControl
	{
		IfcIdentifier @RequestID { get; }
	
	}
}

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[ExpressType("IFCACTIONREQUEST", 516)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcActionRequest : IfcControl, IInstantiableEntity, IIfcActionRequest, IEqualityComparer<@IfcActionRequest>, IEquatable<@IfcActionRequest>
	{
		#region IIfcActionRequest explicit implementation
		IfcIdentifier IIfcActionRequest.RequestID { get { return @RequestID; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcActionRequest(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _requestID;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @RequestID 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _requestID;
				((IPersistEntity)this).Activate(false);
				return _requestID;
			} 
			set
			{
				SetValue( v =>  _requestID = v, _requestID, value,  "RequestID");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_requestID = value.StringVal;
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
        public bool Equals(@IfcActionRequest other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcActionRequest
            var root = (@IfcActionRequest)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcActionRequest left, @IfcActionRequest right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcActionRequest left, @IfcActionRequest right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcActionRequest x, @IfcActionRequest y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcActionRequest obj)
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