using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//***Log4Net_Test: include this entire file

// depends on running this script in the database referenced in log4net.config and named: MVA_DLS
//use App_Log  --modify to use your chosen loggin database
//go
//CREATE TABLE [dbo].[LogEntries] (
//    [Id] [int] IDENTITY (1, 1) NOT NULL,
//    [Date] [datetime] NOT NULL,
//    [Thread] [varchar] (255) NOT NULL,
//    [Level] [varchar] (50) NOT NULL,
//    [Logger] [varchar] (255) NOT NULL,
//    [Message] [varchar] (4000) NOT NULL,
//    [Exception] [varchar] (2000) NULL
//);

namespace mvc_Log4Net
{
    /// <summary>
    /// Log - global logging class based on Log4Net
    /// </summary>
    public static class Log
    {
        //log4Net local logger reference
        private static log4net.ILog mvcLog { get; set; }

        //ctor
        static Log()
        {
            mvcLog = log4net.LogManager.GetLogger(typeof(Log));
        }

        //Debug
        public static void Debug(object msg)
        {
            mvcLog.Debug(msg);
        }
        public static void Debug(object msg, Exception ex)
        {
            mvcLog.Debug(msg, ex);
        }
        public static void DebugFormat(string format, object arg)
        {
            mvcLog.DebugFormat(format, arg);
        }
        public static void DebugFormat(string format, params object[] args)
        {
            mvcLog.DebugFormat(format, args);
        }
        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            mvcLog.DebugFormat(provider, format, args);
        }

        //Error, exception
        public static void Error(object msg)
        {
            mvcLog.Error(msg);
        }
        public static void Error(object msg, Exception ex)
        {
            mvcLog.Error(msg, ex);
        }
        public static void Error(Exception ex)
        {
            mvcLog.Error(ex.Message, ex);
        }
        public static void ErrorFormat(string format, object arg)
        {
            mvcLog.ErrorFormat(format, arg);
        }
        public static void ErrorFormat(string format, params object[] args)
        {
            mvcLog.ErrorFormat(format, args);
        }
        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            mvcLog.ErrorFormat(provider, format, args);
        }

        //FATAL
        public static void Fatal(object msg)
        {
            mvcLog.Fatal(msg);
        }
        public static void Fatal(object msg, Exception ex)
        {
            mvcLog.Fatal(msg, ex);
        }
        public static void FatalFormat(string format, object arg)
        {
            mvcLog.FatalFormat(format, arg);
        }
        public static void FatalFormat(string format, params object[] args)
        {
            mvcLog.FatalFormat(format, args);
        }
        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            mvcLog.FatalFormat(provider, format, args);
        }

        //Information
        public static void Info(object msg)
        {
            mvcLog.Info(msg);
        }
        public static void Info(object msg, Exception ex)
        {
            mvcLog.Info(msg, ex);
        }
        public static void InfoFormat(string format, object arg)
        {
            mvcLog.InfoFormat(format, arg);
        }
        public static void Info(string format, params object[] args)
        {
            mvcLog.InfoFormat(format, args);
        }
        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            mvcLog.InfoFormat(provider, format, args);
        }

        //Warning
        public static void Warn(object msg)
        {
            mvcLog.Warn(msg);
        }
        public static void WarnFormat(string format, object msg)
        {
            mvcLog.WarnFormat(format, msg);
        }
        public static void WarnFormat(string format, params object[] args)
        {
            mvcLog.WarnFormat(format, args);
        }
        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            mvcLog.WarnFormat(provider, format, args);
        }
    }
}