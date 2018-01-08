﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using XComponent.Engine.Processing;
using XComponent.Common.Processing;
using XComponent.Engine.Processing.Domain;
using XComponent.Common.ApiContext;
using XComponent.Communication;

namespace XComponent.Trade.Common
{
    public class InternalCommunication : IInternalCommunication
    {
        private const string ComponentName = "Trade";

		private IAgentManager _agentManager;
        private Dictionary<int, EngineAgent> _engineAgentsById = new Dictionary<int, EngineAgent>();
        private Dictionary<int, List<EngineAgent>> _engineAgentsByStateMachine = new Dictionary<int, List<EngineAgent>>();

        public InternalCommunication(IAgentManager agentManager)
        {
            _agentManager = agentManager;
        }
		
        public void Init(string configFile)
        {
			foreach( var engineAgent in _agentManager.FilterEngineAgentForInternalAPI(-729436854))
			{
				_engineAgentsById.Add(engineAgent.Id, engineAgent);
				
				foreach( var detail in Agent.getAgentDetails(engineAgent))
				{
					if (detail.Key.Equals(-729436854))
					{
						foreach( var stateMachineCode in detail.Value )
						{
							if(!_engineAgentsByStateMachine.ContainsKey(stateMachineCode))
							{
								_engineAgentsByStateMachine.Add(stateMachineCode, new List<EngineAgent>());
							}

							_engineAgentsByStateMachine[stateMachineCode].Add(engineAgent);
						}
					}
				}
			}
        }

		public void Send(Context context, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), IncomingEventType.Transition, HeaderFactory.Create(context, 6, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            SendEvent(StdEnum.TradeProcessor, evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), IncomingEventType.Transition, HeaderFactory.Create(6, (int)stateMachineEnum, -729436854, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Order.UserObject.OrderCreation(), IncomingEventType.Transition, HeaderFactory.Create(context, 10, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null)
        {
            SendEvent(StdEnum.TradeProcessor, evt != null ? evt : new XComponent.Order.UserObject.OrderCreation(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Order.UserObject.OrderCreation(), IncomingEventType.Transition, HeaderFactory.Create(10, (int)stateMachineEnum, -729436854, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Trade.UserObject.Trade evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Trade.UserObject.Trade(), IncomingEventType.Transition, HeaderFactory.Create(context, 13, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Trade.UserObject.Trade evt, string privateTopic = null)
        {
            SendEvent(StdEnum.TradeProcessor, evt != null ? evt : new XComponent.Trade.UserObject.Trade(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Trade.UserObject.Trade evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Trade.UserObject.Trade(), IncomingEventType.Transition, HeaderFactory.Create(13, (int)stateMachineEnum, -729436854, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Trade.UserObject.TradeExecution evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Trade.UserObject.TradeExecution(), IncomingEventType.Transition, HeaderFactory.Create(context, 14, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Trade.UserObject.TradeExecution evt, string privateTopic = null)
        {
            SendEvent(StdEnum.TradeProcessor, evt != null ? evt : new XComponent.Trade.UserObject.TradeExecution(), privateTopic);
            SendEvent(StdEnum.Trade, evt != null ? evt : new XComponent.Trade.UserObject.TradeExecution(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Trade.UserObject.TradeExecution evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Trade.UserObject.TradeExecution(), IncomingEventType.Transition, HeaderFactory.Create(14, (int)stateMachineEnum, -729436854, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Order.UserObject.OrderExecution(), IncomingEventType.Transition, HeaderFactory.Create(context, 11, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null)
        {
            SendEvent(StdEnum.TradeProcessor, evt != null ? evt : new XComponent.Order.UserObject.OrderExecution(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Order.UserObject.OrderExecution(), IncomingEventType.Transition, HeaderFactory.Create(11, (int)stateMachineEnum, -729436854, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		private void PostOnStateMachine(IncomingEvent incomingEvent, StdEnum stateMachineEnum)
		{
			foreach(var engineAgent in GetEngineAgents(stateMachineEnum))
			{
				Agent.Post(engineAgent, incomingEvent);
			}
		}

		private IEnumerable<EngineAgent> GetEngineAgents(StdEnum stateMachineEnum)
        {
			switch(stateMachineEnum)
			{
				case StdEnum.TradeProcessor :
					return _engineAgentsByStateMachine[190855629];
				case StdEnum.Trade :
					return _engineAgentsByStateMachine[-729436854];
			}

            return new List<EngineAgent>();
        }
    }
}
