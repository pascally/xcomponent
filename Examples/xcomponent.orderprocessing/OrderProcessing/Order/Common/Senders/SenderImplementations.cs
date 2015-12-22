//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace XComponent.Order.Common.Senders
{
    using System;
    using XComponent.Common.ApiContext;
    using XComponent.Order.Common;

	public class ExecuteExecutionInputOnExecutedOrderSender : AbstractSender, IExecuteExecutionInputOnExecutedOrderSenderInterface
    {
		public void PublishOrderFilled(Context context)
			{
				internalAPI.PublishOrderFilled(context);
			}
		
		
		public void PublishOrderFilled(Context context, XComponent.Order.UserObject.OrderExecution transitionEvent)
			{
				internalAPI.PublishOrderFilled(context, transitionEvent);
			}
		
		
		public void SendEvent(XComponent.Order.UserObject.OrderExecution evt)
			{
				internalAPI.SendEvent(evt);
			}
			
			public void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderExecution evt)
			{
				internalAPI.SendEvent(stdEnum, evt);
			}
		
    }
	public class PartiallyExecuteExecutionInputOnPartiallyExecutedOrderSender : AbstractSender, IPartiallyExecuteExecutionInputOnPartiallyExecutedOrderSenderInterface
    {
		public void PublishOrderPartiallyFilled(Context context)
			{
				internalAPI.PublishOrderPartiallyFilled(context);
			}
		
		
		public void PublishOrderPartiallyFilled(Context context, XComponent.Order.UserObject.OrderExecution transitionEvent)
			{
				internalAPI.PublishOrderPartiallyFilled(context, transitionEvent);
			}
		
		
		public void SendEvent(XComponent.Order.UserObject.OrderExecution evt)
			{
				internalAPI.SendEvent(evt);
			}
			
			public void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderExecution evt)
			{
				internalAPI.SendEvent(stdEnum, evt);
			}
		
    }
	public class CreateOrderOrderInputOnPendingOrderSender : AbstractSender, ICreateOrderOrderInputOnPendingOrderSenderInterface
    {
		public void PublishOrderCreation(Context context)
			{
				internalAPI.PublishOrderCreation(context);
			}
		
		
		public void PublishOrderCreation(Context context, XComponent.Order.UserObject.OrderCreation transitionEvent)
			{
				internalAPI.PublishOrderCreation(context, transitionEvent);
			}
		
		
		public void SendEvent(XComponent.Order.UserObject.OrderCreation evt)
			{
				internalAPI.SendEvent(evt);
			}
			
			public void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderCreation evt)
			{
				internalAPI.SendEvent(stdEnum, evt);
			}
		
    }
	public class PublishOrderCreationOrderCreationOnCreatedCreationFacadeSender : AbstractSender, IPublishOrderCreationOrderCreationOnCreatedCreationFacadeSenderInterface
    {
		
		
		
		
		
    }
	public class PublishOrderFilledOrderExecutionOnFilledExecutionFacadeSender : AbstractSender, IPublishOrderFilledOrderExecutionOnFilledExecutionFacadeSenderInterface
    {
		
		
		
		
		
    }
	public class PublishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender : AbstractSender, IPublishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSenderInterface
    {
		
		
		
		
		
    }
	
}
