// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_passthrough")]
    public unsafe partial class FBPassthrough : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_passthrough";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateGeometryInstanceFB")]
        public unsafe partial Result CreateGeometryInstanceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] GeometryInstanceCreateInfoFB* createInfo, [Count(Count = 0)] GeometryInstanceFB* outGeometryInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateGeometryInstanceFB")]
        public unsafe partial Result CreateGeometryInstanceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] GeometryInstanceCreateInfoFB* createInfo, [Count(Count = 0)] ref GeometryInstanceFB outGeometryInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateGeometryInstanceFB")]
        public unsafe partial Result CreateGeometryInstanceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in GeometryInstanceCreateInfoFB createInfo, [Count(Count = 0)] GeometryInstanceFB* outGeometryInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateGeometryInstanceFB")]
        public partial Result CreateGeometryInstanceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in GeometryInstanceCreateInfoFB createInfo, [Count(Count = 0)] ref GeometryInstanceFB outGeometryInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughFB")]
        public unsafe partial Result CreatePassthroughFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] PassthroughCreateInfoFB* createInfo, [Count(Count = 0)] PassthroughFB* outPassthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughFB")]
        public unsafe partial Result CreatePassthroughFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] PassthroughCreateInfoFB* createInfo, [Count(Count = 0)] ref PassthroughFB outPassthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughFB")]
        public unsafe partial Result CreatePassthroughFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in PassthroughCreateInfoFB createInfo, [Count(Count = 0)] PassthroughFB* outPassthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughFB")]
        public partial Result CreatePassthroughFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in PassthroughCreateInfoFB createInfo, [Count(Count = 0)] ref PassthroughFB outPassthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughLayerFB")]
        public unsafe partial Result CreatePassthroughLayerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] PassthroughLayerCreateInfoFB* createInfo, [Count(Count = 0)] PassthroughLayerFB* outLayer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughLayerFB")]
        public unsafe partial Result CreatePassthroughLayerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] PassthroughLayerCreateInfoFB* createInfo, [Count(Count = 0)] ref PassthroughLayerFB outLayer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughLayerFB")]
        public unsafe partial Result CreatePassthroughLayerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in PassthroughLayerCreateInfoFB createInfo, [Count(Count = 0)] PassthroughLayerFB* outLayer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughLayerFB")]
        public partial Result CreatePassthroughLayerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in PassthroughLayerCreateInfoFB createInfo, [Count(Count = 0)] ref PassthroughLayerFB outLayer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyGeometryInstanceFB")]
        public partial Result DestroyGeometryInstanceFB([Count(Count = 0)] GeometryInstanceFB instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyPassthroughFB")]
        public partial Result DestroyPassthroughFB([Count(Count = 0)] PassthroughFB passthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyPassthroughLayerFB")]
        public partial Result DestroyPassthroughLayerFB([Count(Count = 0)] PassthroughLayerFB layer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGeometryInstanceSetTransformFB")]
        public unsafe partial Result GeometryInstanceSetTransformFB([Count(Count = 0)] GeometryInstanceFB instance, [Count(Count = 0), Flow(FlowDirection.In)] GeometryInstanceTransformFB* transformation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGeometryInstanceSetTransformFB")]
        public partial Result GeometryInstanceSetTransformFB([Count(Count = 0)] GeometryInstanceFB instance, [Count(Count = 0), Flow(FlowDirection.In)] in GeometryInstanceTransformFB transformation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughLayerPauseFB")]
        public partial Result PassthroughLayerPauseFB([Count(Count = 0)] PassthroughLayerFB layer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughLayerResumeFB")]
        public partial Result PassthroughLayerResumeFB([Count(Count = 0)] PassthroughLayerFB layer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughLayerSetStyleFB")]
        public unsafe partial Result PassthroughLayerSetStyleFB([Count(Count = 0)] PassthroughLayerFB layer, [Count(Count = 0), Flow(FlowDirection.In)] PassthroughStyleFB* style);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughLayerSetStyleFB")]
        public partial Result PassthroughLayerSetStyleFB([Count(Count = 0)] PassthroughLayerFB layer, [Count(Count = 0), Flow(FlowDirection.In)] in PassthroughStyleFB style);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughPauseFB")]
        public partial Result PassthroughPauseFB([Count(Count = 0)] PassthroughFB passthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughStartFB")]
        public partial Result PassthroughStartFB([Count(Count = 0)] PassthroughFB passthrough);

        public FBPassthrough(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

