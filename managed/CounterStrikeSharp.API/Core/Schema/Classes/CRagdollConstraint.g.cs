// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CRagdollConstraint : CPhysConstraint
{
    public CRagdollConstraint (IntPtr pointer) : base(pointer) {}

	// m_xmin
	[SchemaMember("CRagdollConstraint", "m_xmin")]
	public ref float Xmin => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_xmin");

	// m_xmax
	[SchemaMember("CRagdollConstraint", "m_xmax")]
	public ref float Xmax => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_xmax");

	// m_ymin
	[SchemaMember("CRagdollConstraint", "m_ymin")]
	public ref float Ymin => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_ymin");

	// m_ymax
	[SchemaMember("CRagdollConstraint", "m_ymax")]
	public ref float Ymax => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_ymax");

	// m_zmin
	[SchemaMember("CRagdollConstraint", "m_zmin")]
	public ref float Zmin => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_zmin");

	// m_zmax
	[SchemaMember("CRagdollConstraint", "m_zmax")]
	public ref float Zmax => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_zmax");

	// m_xfriction
	[SchemaMember("CRagdollConstraint", "m_xfriction")]
	public ref float Xfriction => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_xfriction");

	// m_yfriction
	[SchemaMember("CRagdollConstraint", "m_yfriction")]
	public ref float Yfriction => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_yfriction");

	// m_zfriction
	[SchemaMember("CRagdollConstraint", "m_zfriction")]
	public ref float Zfriction => ref Schema.GetRef<float>(this.Handle, "CRagdollConstraint", "m_zfriction");

}