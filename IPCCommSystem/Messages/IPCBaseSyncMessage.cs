﻿using System;
using SimpleIPCCommSystem.Utilities;

namespace SimpleIPCCommSystem.Messages {

    public class IPCBaseSyncMessage : MarshalByRefObject, IIPCBaseMessage, IIPCSharedObject {

        public IPCBaseSyncMessage(IIPCGUID senderID,
            int timeout) {
            _senderID = senderID;
            _timeout = timeout;
        }

        private IIPCGUID _senderID;
        public IIPCGUID SenderID {
            get { return _senderID; }
            set { _senderID = value; }
        }

        public IPCDispatchType MessageType {
            get { return IPCDispatchType.Sync; }
        }

        private int _timeout;

        public int TimeOut {
            get { return _timeout; }
            set { _timeout = value; }
        }

        public string UriSuffix {
            get { return "BaseSyncMessageSuffix"; }
        }
    }

}