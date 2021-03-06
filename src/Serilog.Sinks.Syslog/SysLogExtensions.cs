﻿using System;
using Serilog;
using Serilog.Configuration;

namespace Axon.Logging
{
    public static class SysLogExtensions
    {
        public static LoggerConfiguration Syslog(this LoggerSinkConfiguration config, string sysLogServer, int port, int batchSize=10, int batchPeriodInseconds=1)
        {
            var sink = new SyslogSink(batchSize, TimeSpan.FromSeconds(batchPeriodInseconds), sysLogServer, port);
            return config.Sink(sink);
        }
    }
}