// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.TopologyResource
{
	public partial class @IfcEdgeCurve : IIfcEdgeCurve
	{

		[CrossSchemaAttribute(typeof(IIfcEdgeCurve), 3)]
		IIfcCurve IIfcEdgeCurve.EdgeGeometry 
		{ 
			get
			{
				return EdgeGeometry;
			} 
			set
			{
				EdgeGeometry = value as GeometryResource.IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcEdgeCurve), 4)]
		Ifc4.MeasureResource.IfcBoolean IIfcEdgeCurve.SameSense 
		{ 
			get
			{
				//## Handle return of SameSense for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(SameSense);
			    //##
			} 
			set
			{
				SameSense = value;
				
			}
		}
	//## Custom code
	//##
	}
}