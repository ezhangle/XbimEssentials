// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.DateTimeResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProcessExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcScheduleTimeControl
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcScheduleTimeControl : IIfcControl
	{
		IIfcDateTimeSelect @ActualStart { get; }
		IIfcDateTimeSelect @EarlyStart { get; }
		IIfcDateTimeSelect @LateStart { get; }
		IIfcDateTimeSelect @ScheduleStart { get; }
		IIfcDateTimeSelect @ActualFinish { get; }
		IIfcDateTimeSelect @EarlyFinish { get; }
		IIfcDateTimeSelect @LateFinish { get; }
		IIfcDateTimeSelect @ScheduleFinish { get; }
		IfcTimeMeasure? @ScheduleDuration { get; }
		IfcTimeMeasure? @ActualDuration { get; }
		IfcTimeMeasure? @RemainingTime { get; }
		IfcTimeMeasure? @FreeFloat { get; }
		IfcTimeMeasure? @TotalFloat { get; }
		bool? @IsCritical { get; }
		IIfcDateTimeSelect @StatusTime { get; }
		IfcTimeMeasure? @StartFloat { get; }
		IfcTimeMeasure? @FinishFloat { get; }
		IfcPositiveRatioMeasure? @Completion { get; }
		IIfcRelAssignsTasks @ScheduleTimeControlAssigned {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ProcessExtension
{
	[ExpressType("IfcScheduleTimeControl", 402)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcScheduleTimeControl : IfcControl, IInstantiableEntity, IIfcScheduleTimeControl, IEquatable<@IfcScheduleTimeControl>
	{
		#region IIfcScheduleTimeControl explicit implementation
		IIfcDateTimeSelect IIfcScheduleTimeControl.ActualStart { get { return @ActualStart; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.EarlyStart { get { return @EarlyStart; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.LateStart { get { return @LateStart; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.ScheduleStart { get { return @ScheduleStart; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.ActualFinish { get { return @ActualFinish; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.EarlyFinish { get { return @EarlyFinish; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.LateFinish { get { return @LateFinish; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.ScheduleFinish { get { return @ScheduleFinish; } }	
		IfcTimeMeasure? IIfcScheduleTimeControl.ScheduleDuration { get { return @ScheduleDuration; } }	
		IfcTimeMeasure? IIfcScheduleTimeControl.ActualDuration { get { return @ActualDuration; } }	
		IfcTimeMeasure? IIfcScheduleTimeControl.RemainingTime { get { return @RemainingTime; } }	
		IfcTimeMeasure? IIfcScheduleTimeControl.FreeFloat { get { return @FreeFloat; } }	
		IfcTimeMeasure? IIfcScheduleTimeControl.TotalFloat { get { return @TotalFloat; } }	
		bool? IIfcScheduleTimeControl.IsCritical { get { return @IsCritical; } }	
		IIfcDateTimeSelect IIfcScheduleTimeControl.StatusTime { get { return @StatusTime; } }	
		IfcTimeMeasure? IIfcScheduleTimeControl.StartFloat { get { return @StartFloat; } }	
		IfcTimeMeasure? IIfcScheduleTimeControl.FinishFloat { get { return @FinishFloat; } }	
		IfcPositiveRatioMeasure? IIfcScheduleTimeControl.Completion { get { return @Completion; } }	
		 
		IIfcRelAssignsTasks IIfcScheduleTimeControl.ScheduleTimeControlAssigned {  get { return @ScheduleTimeControlAssigned; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcScheduleTimeControl(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDateTimeSelect _actualStart;
		private IfcDateTimeSelect _earlyStart;
		private IfcDateTimeSelect _lateStart;
		private IfcDateTimeSelect _scheduleStart;
		private IfcDateTimeSelect _actualFinish;
		private IfcDateTimeSelect _earlyFinish;
		private IfcDateTimeSelect _lateFinish;
		private IfcDateTimeSelect _scheduleFinish;
		private IfcTimeMeasure? _scheduleDuration;
		private IfcTimeMeasure? _actualDuration;
		private IfcTimeMeasure? _remainingTime;
		private IfcTimeMeasure? _freeFloat;
		private IfcTimeMeasure? _totalFloat;
		private bool? _isCritical;
		private IfcDateTimeSelect _statusTime;
		private IfcTimeMeasure? _startFloat;
		private IfcTimeMeasure? _finishFloat;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcDateTimeSelect @ActualStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualStart;
				((IPersistEntity)this).Activate(false);
				return _actualStart;
			} 
			set
			{
				SetValue( v =>  _actualStart = v, _actualStart, value,  "ActualStart");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcDateTimeSelect @EarlyStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _earlyStart;
				((IPersistEntity)this).Activate(false);
				return _earlyStart;
			} 
			set
			{
				SetValue( v =>  _earlyStart = v, _earlyStart, value,  "EarlyStart");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public IfcDateTimeSelect @LateStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lateStart;
				((IPersistEntity)this).Activate(false);
				return _lateStart;
			} 
			set
			{
				SetValue( v =>  _lateStart = v, _lateStart, value,  "LateStart");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public IfcDateTimeSelect @ScheduleStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleStart;
				((IPersistEntity)this).Activate(false);
				return _scheduleStart;
			} 
			set
			{
				SetValue( v =>  _scheduleStart = v, _scheduleStart, value,  "ScheduleStart");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 16)]
		public IfcDateTimeSelect @ActualFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualFinish;
				((IPersistEntity)this).Activate(false);
				return _actualFinish;
			} 
			set
			{
				SetValue( v =>  _actualFinish = v, _actualFinish, value,  "ActualFinish");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 17)]
		public IfcDateTimeSelect @EarlyFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _earlyFinish;
				((IPersistEntity)this).Activate(false);
				return _earlyFinish;
			} 
			set
			{
				SetValue( v =>  _earlyFinish = v, _earlyFinish, value,  "EarlyFinish");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 18)]
		public IfcDateTimeSelect @LateFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lateFinish;
				((IPersistEntity)this).Activate(false);
				return _lateFinish;
			} 
			set
			{
				SetValue( v =>  _lateFinish = v, _lateFinish, value,  "LateFinish");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcDateTimeSelect @ScheduleFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleFinish;
				((IPersistEntity)this).Activate(false);
				return _scheduleFinish;
			} 
			set
			{
				SetValue( v =>  _scheduleFinish = v, _scheduleFinish, value,  "ScheduleFinish");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public IfcTimeMeasure? @ScheduleDuration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleDuration;
				((IPersistEntity)this).Activate(false);
				return _scheduleDuration;
			} 
			set
			{
				SetValue( v =>  _scheduleDuration = v, _scheduleDuration, value,  "ScheduleDuration");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcTimeMeasure? @ActualDuration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualDuration;
				((IPersistEntity)this).Activate(false);
				return _actualDuration;
			} 
			set
			{
				SetValue( v =>  _actualDuration = v, _actualDuration, value,  "ActualDuration");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public IfcTimeMeasure? @RemainingTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _remainingTime;
				((IPersistEntity)this).Activate(false);
				return _remainingTime;
			} 
			set
			{
				SetValue( v =>  _remainingTime = v, _remainingTime, value,  "RemainingTime");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 23)]
		public IfcTimeMeasure? @FreeFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _freeFloat;
				((IPersistEntity)this).Activate(false);
				return _freeFloat;
			} 
			set
			{
				SetValue( v =>  _freeFloat = v, _freeFloat, value,  "FreeFloat");
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 24)]
		public IfcTimeMeasure? @TotalFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _totalFloat;
				((IPersistEntity)this).Activate(false);
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat");
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 25)]
		public bool? @IsCritical 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isCritical;
				((IPersistEntity)this).Activate(false);
				return _isCritical;
			} 
			set
			{
				SetValue( v =>  _isCritical = v, _isCritical, value,  "IsCritical");
			} 
		}	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 26)]
		public IfcDateTimeSelect @StatusTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _statusTime;
				((IPersistEntity)this).Activate(false);
				return _statusTime;
			} 
			set
			{
				SetValue( v =>  _statusTime = v, _statusTime, value,  "StatusTime");
			} 
		}	
		[EntityAttribute(21, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 27)]
		public IfcTimeMeasure? @StartFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startFloat;
				((IPersistEntity)this).Activate(false);
				return _startFloat;
			} 
			set
			{
				SetValue( v =>  _startFloat = v, _startFloat, value,  "StartFloat");
			} 
		}	
		[EntityAttribute(22, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 28)]
		public IfcTimeMeasure? @FinishFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _finishFloat;
				((IPersistEntity)this).Activate(false);
				return _finishFloat;
			} 
			set
			{
				SetValue( v =>  _finishFloat = v, _finishFloat, value,  "FinishFloat");
			} 
		}	
		[EntityAttribute(23, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 29)]
		public IfcPositiveRatioMeasure? @Completion 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _completion;
				((IPersistEntity)this).Activate(false);
				return _completion;
			} 
			set
			{
				SetValue( v =>  _completion = v, _completion, value,  "Completion");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("TimeForTask")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 30)]
		public IfcRelAssignsTasks @ScheduleTimeControlAssigned 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcRelAssignsTasks>(e => Equals(e.TimeForTask), "TimeForTask", this);
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
					_actualStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 6: 
					_earlyStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 7: 
					_lateStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 8: 
					_scheduleStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 9: 
					_actualFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 10: 
					_earlyFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 11: 
					_lateFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 12: 
					_scheduleFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 13: 
					_scheduleDuration = value.RealVal;
					return;
				case 14: 
					_actualDuration = value.RealVal;
					return;
				case 15: 
					_remainingTime = value.RealVal;
					return;
				case 16: 
					_freeFloat = value.RealVal;
					return;
				case 17: 
					_totalFloat = value.RealVal;
					return;
				case 18: 
					_isCritical = value.BooleanVal;
					return;
				case 19: 
					_statusTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 20: 
					_startFloat = value.RealVal;
					return;
				case 21: 
					_finishFloat = value.RealVal;
					return;
				case 22: 
					_completion = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcScheduleTimeControl other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcScheduleTimeControl
            var root = (@IfcScheduleTimeControl)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcScheduleTimeControl left, @IfcScheduleTimeControl right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcScheduleTimeControl left, @IfcScheduleTimeControl right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}