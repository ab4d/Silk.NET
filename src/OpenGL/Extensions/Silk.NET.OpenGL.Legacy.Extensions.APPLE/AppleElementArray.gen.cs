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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_element_array")]
    public unsafe partial class AppleElementArray : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_element_array";
        [NativeApi(EntryPoint = "glDrawElementArrayAPPLE")]
        public partial void DrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElementArrayAPPLE")]
        public partial void DrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayAPPLE")]
        public partial void DrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayAPPLE")]
        public partial void DrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glElementPointerAPPLE")]
        public unsafe partial void ElementPointer([Flow(FlowDirection.In)] APPLE type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glElementPointerAPPLE")]
        public unsafe partial void ElementPointer([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public unsafe partial void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public unsafe partial void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public unsafe partial void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public partial void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public unsafe partial void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public unsafe partial void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public unsafe partial void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public partial void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public unsafe partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public unsafe partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public unsafe partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public unsafe partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public unsafe partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public unsafe partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public partial void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        public unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public AppleElementArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

