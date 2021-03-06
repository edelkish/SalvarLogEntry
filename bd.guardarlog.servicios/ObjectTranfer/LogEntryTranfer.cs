﻿using System;

namespace bd.log.guardar.ObjectTranfer
{
    public class LogEntryTranfer
    {
        public string LogLevelShortName { get; set; }

        public string LogCategoryParametre { get; set;}

        public Exception ExceptionTrace { get; set; }

        public string Message { get; set; }

        public string EntityID { get; set; }

        public string UserName { get; set; }

        public string ApplicationName { get; set; }
    }
}
