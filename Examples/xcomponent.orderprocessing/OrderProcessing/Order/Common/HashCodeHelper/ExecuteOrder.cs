//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace XComponent.Order.Common
{
    using System;
    using XComponent.Common.ApiContext;
    using XComponent.Common.Helper;
    using XComponent.Common.Hashcode;
    using Microsoft.FSharp.Collections;
    using Microsoft.FSharp.Core;
    
    
    public class ExecuteOrder : XComponent.Common.Hashcode.IHashcodeGenerator
    {
        
        public Tuple<Microsoft.FSharp.Core.FSharpOption<System.Int32>, Boolean> Generate(Object evt)
        {
            if (evt is XComponent.Order.UserObject.ExecutionInput)
            {
                XComponent.Order.UserObject.ExecutionInput typedEvt = ((XComponent.Order.UserObject.ExecutionInput)(evt));
                #pragma warning disable 472
				var OrderIdHC = typedEvt.OrderId != null ? HashcodeHelper.GetXcHashCode(typedEvt.OrderId) : -1;
				
                return new Tuple<Microsoft.FSharp.Core.FSharpOption<System.Int32>, Boolean>(FSharpOption<int>.Some(OrderIdHC), false);
            }
            return new Tuple<Microsoft.FSharp.Core.FSharpOption<System.Int32>, Boolean>(FSharpOption<int>.None, false);
        }
    }
}