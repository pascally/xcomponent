//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace XComponent.Referential.Common
{
    using System;
    using XComponent.Common.ApiContext;
    using Microsoft.FSharp.Collections;
    using Microsoft.FSharp.Core;
    
    
    public interface IInternalAPI
    {
		void Start(Context context);
			
		void AddInstrument(Context context);
			
		void GetInstrumentSnapshot(Context context);
			
		
		
		void Start(Context context, XComponent.Common.Event.DefaultEvent transitionEvent);
			
		void AddInstrument(Context context, XComponent.Referential.UserObject.Instrument transitionEvent);
			
		void GetInstrumentSnapshot(Context context, XComponent.Referential.UserObject.GetSnapshot transitionEvent);
			
		
		
		void SendEvent(XComponent.Referential.UserObject.Instrument evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.Instrument evt);
			
		void SendEvent(XComponent.Referential.UserObject.GetSnapshot evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.GetSnapshot evt);
			
		
    }
}