﻿




////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by XCTools.
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------
using System;
using XComponent.Calculator.Common;
using XComponent.Calculator.Common.Senders;
using XComponent.Runtime.Shared.TriggeredMethods;
using XComponent.Runtime.Shared.Manager;
using XComponent.Common.Logger;
using XComponent.Common.Logger.Logger;

using XComponent.Functions.Core;


namespace XComponent.Calculator.TriggeredMethod
{
    public partial class TriggeredMethodContext : ICustomTriggeredMethodContext
    {
        enum DefaultLogger
        {
            CalculatorDefaultLogger
        }

        private IComponentLogger _defaultLogger = XComponent.Common.Logger.Managers.ComponentLoggerManager<DefaultLogger>.GetComponentLogger(DefaultLogger.CalculatorDefaultLogger, ComponentHelper.COMPONENT_NAME);

        
        private static ICustomTriggeredMethodContext instance = new TriggeredMethodContext();
        
        static TriggeredMethodContext()
        {
        }
        
        private TriggeredMethodContext()
        {
        }
        
        public static ICustomTriggeredMethodContext Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }


		public IFunctionsManager CalculatorFunctionManager { get; set; }

		public IFunctionsManager CalculatorManagerFunctionManager { get; set; }
 
        private ComponentManager componentManager;
        
        public IComponentManager ComponentManager
        {
            get
            {
                return componentManager;
            }
        }
        
        public IComponentLogger GetLogger(LogKeyEnum loggerName)
        {
				return  Loggers.GetLogger(loggerName);
        }

		public IComponentLogger GetDefaultLogger()
		{
				return  _defaultLogger;
		}
 
        
		class StmEndPoint
        {
            public StmEndPoint(StdEnum stateMachine)
            {
                StateMachine = stateMachine;
            }
            public StdEnum StateMachine { get; private set; }

            public Uri RestEndPointUrl { get; set; }
        }

        partial void GetRestEndPointUrl(StmEndPoint stmEndPoint);

        private Uri GetRestEndPointUrl(StdEnum stmName)
        {
            StmEndPoint stmEndPoint = new StmEndPoint(stmName);
			var key = stmName.ToString() + "_FunctionManagerServiceUrl";
            if (ComponentManager.KeyValueParameters.IsKeyExists(key))
            {
                stmEndPoint.RestEndPointUrl = new Uri(ComponentManager.KeyValueParameters.GetValue(key));
            }
            else
            {
				if (ComponentManager.FunctionManagerServiceUrl != null) {
					stmEndPoint.RestEndPointUrl = new Uri(ComponentManager.FunctionManagerServiceUrl);
				} else {
					stmEndPoint.RestEndPointUrl = FunctionsFactory.DefaultUrl;
				}
            }
            GetRestEndPointUrl(stmEndPoint);
            return stmEndPoint.RestEndPointUrl;
        }


        public void Init(ComponentManager componentMgrInput)
        {
				_defaultLogger.Enable();
				componentManager = componentMgrInput;

				Environment.SetEnvironmentVariable("OWIN_SERVER", "Microsoft.Owin.Host.HttpListener.OwinServerFactory, XComponent.Core");
				try {
					Uri uri;

				    uri = GetRestEndPointUrl(StdEnum.Calculator);
					CalculatorFunctionManager = FunctionsFactory.Instance.CreateFunctionsManager(ComponentHelper.COMPONENT_NAME, StdEnum.Calculator.ToString(), uri);
					_defaultLogger.Info(string.Format("{1} - Endpoint address : {0}", uri, StdEnum.Calculator.ToString()));
					_defaultLogger.Info(string.Format("{1} - Endpoint swagger address : {0}swagger/ui/index", uri, StdEnum.Calculator.ToString()));


				    uri = GetRestEndPointUrl(StdEnum.CalculatorManager);
					CalculatorManagerFunctionManager = FunctionsFactory.Instance.CreateFunctionsManager(ComponentHelper.COMPONENT_NAME, StdEnum.CalculatorManager.ToString(), uri);
					_defaultLogger.Info(string.Format("{1} - Endpoint address : {0}", uri, StdEnum.CalculatorManager.ToString()));
					_defaultLogger.Info(string.Format("{1} - Endpoint swagger address : {0}swagger/ui/index", uri, StdEnum.CalculatorManager.ToString()));



				} catch(Exception e)
				{
					_defaultLogger.Error(string.Format("Error during Functions Manager creation : {0}", e));
				}


				OnComponentInitialized();
        }
        
        public string GetParameterValue(KeyValueParametersEnum keyValueParameter)
        {
				if (componentManager.KeyValueParameters.IsKeyExists(keyValueParameter.ToString())) {
				return componentManager.KeyValueParameters.GetValue(keyValueParameter.ToString()); }
				return null;
        }
    }
    
    public partial interface ICustomTriggeredMethodContext : ITriggeredMethodContext
    {
        
        string GetParameterValue(KeyValueParametersEnum keyValueParameter);
        
        IComponentLogger GetLogger(LogKeyEnum loggerName);

        IComponentLogger GetDefaultLogger();

        IComponentManager ComponentManager
        {
            get;
        }


		IFunctionsManager CalculatorFunctionManager { get; }

		IFunctionsManager CalculatorManagerFunctionManager { get; }

	}
}