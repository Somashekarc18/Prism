// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Mvvm.Interfaces;

namespace Prism.Windows.Tests.Mocks
{
    public class MockSessionStateService : ISessionStateService
    {
        public Func<IFrameFacade, Dictionary<string, object>> GetSessionStateForFrameDelegate { get; set; }

        public MockSessionStateService()
        {
            SessionState = new Dictionary<string, object>();
        }

        public Dictionary<string, object> SessionState { get; private set; }

        public void RegisterKnownType(Type type)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task RestoreSessionStateAsync()
        {
            throw new NotImplementedException();
        }

        public void RestoreFrameState()
        {
            throw new NotImplementedException();
        }

        public void RegisterFrame(IFrameFacade frame, string sessionStateKey)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFrame(IFrameFacade frame)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetSessionStateForFrame(IFrameFacade frame)
        {
            return GetSessionStateForFrameDelegate(frame);
        }
    }
}
