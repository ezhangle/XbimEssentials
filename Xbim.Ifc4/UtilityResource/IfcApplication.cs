// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.UtilityResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcApplication
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcApplication : IPersistEntity
	{
		IIfcOrganization @ApplicationDeveloper { get; }
		IfcLabel @Version { get; }
		IfcLabel @ApplicationFullName { get; }
		IfcIdentifier @ApplicationIdentifier { get; }
	
	}
}

namespace Xbim.Ifc4.UtilityResource
{
	[IndexedClass]
	[ExpressType("IFCAPPLICATION", 416)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApplication : INotifyPropertyChanged, IInstantiableEntity, IIfcApplication, IEqualityComparer<@IfcApplication>, IEquatable<@IfcApplication>
	{
		#region IIfcApplication explicit implementation
		IIfcOrganization IIfcApplication.ApplicationDeveloper { get { return @ApplicationDeveloper; } }	
		IfcLabel IIfcApplication.Version { get { return @Version; } }	
		IfcLabel IIfcApplication.ApplicationFullName { get { return @ApplicationFullName; } }	
		IfcIdentifier IIfcApplication.ApplicationIdentifier { get { return @ApplicationIdentifier; } }	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApplication(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcOrganization _applicationDeveloper;
		private IfcLabel _version;
		private IfcLabel _applicationFullName;
		private IfcIdentifier _applicationIdentifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcOrganization @ApplicationDeveloper 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _applicationDeveloper;
				((IPersistEntity)this).Activate(false);
				return _applicationDeveloper;
			} 
			set
			{
				SetValue( v =>  _applicationDeveloper = v, _applicationDeveloper, value,  "ApplicationDeveloper");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Version 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _version;
				((IPersistEntity)this).Activate(false);
				return _version;
			} 
			set
			{
				SetValue( v =>  _version = v, _version, value,  "Version");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @ApplicationFullName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _applicationFullName;
				((IPersistEntity)this).Activate(false);
				return _applicationFullName;
			} 
			set
			{
				SetValue( v =>  _applicationFullName = v, _applicationFullName, value,  "ApplicationFullName");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @ApplicationIdentifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _applicationIdentifier;
				((IPersistEntity)this).Activate(false);
				return _applicationIdentifier;
			} 
			set
			{
				SetValue( v =>  _applicationIdentifier = v, _applicationIdentifier, value,  "ApplicationIdentifier");
			} 
		}	
		#endregion




		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_applicationDeveloper = (IfcOrganization)(value.EntityVal);
					return;
				case 1: 
					_version = value.StringVal;
					return;
				case 2: 
					_applicationFullName = value.StringVal;
					return;
				case 3: 
					_applicationIdentifier = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcApplication other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcApplication
            var root = (@IfcApplication)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcApplication left, @IfcApplication right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcApplication left, @IfcApplication right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcApplication x, @IfcApplication y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcApplication obj)
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