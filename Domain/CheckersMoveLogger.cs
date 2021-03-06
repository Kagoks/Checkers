﻿using System.Collections.Generic;

namespace Domain
{
    public class CheckersMoveLogger
    {
        private List<UIListener> listeners;
        private List<CheckersLog> logs;


        public CheckersMoveLogger(List<UIListener> listeners)
        {
            logs = new List<CheckersLog>();
            this.listeners = listeners;
        }

        public void addLog(CheckersLog log)
        {
            logs.Add(log);
            notifyAllListeners(log.ToString());
        }

        private void notifyAllListeners(string log)
        {
            foreach(UIListener listener in listeners)
            {
                listener.UpdateLog(log);
            }
        }
    }
}
