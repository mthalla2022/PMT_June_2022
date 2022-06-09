﻿using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrara.Compass.DragonflyUpdateTimerJob.Classes
{
    public class LoggingService : SPDiagnosticsServiceBase
    {
        public static string FerraraDiagnosticAreaName = "Compass";

        // Logging Diagnostic Areas
        public static string WebPartLoggingDiagnosticArea = "DragonflyUpdateTimerJob";

        private static LoggingService _Current;

        public static LoggingService Current
        { get { if (_Current == null) { _Current = new LoggingService(); } return _Current; } }

        private LoggingService() : base("Ferrara Logging Service", SPFarm.Local)
        {
        }

        protected override IEnumerable<SPDiagnosticsArea> ProvideAreas()
        {
            List<SPDiagnosticsArea> areas = new List<SPDiagnosticsArea>
            {
                new SPDiagnosticsArea(FerraraDiagnosticAreaName, new List<SPDiagnosticsCategory>
                {
                    new SPDiagnosticsCategory(WebPartLoggingDiagnosticArea, TraceSeverity.Unexpected, EventSeverity.Error)
                })
            };

            return areas;
        }

        public static void LogError(string categoryName, string errorMessage)
        {
            SPDiagnosticsCategory category = LoggingService.Current.Areas[FerraraDiagnosticAreaName].Categories[categoryName];
            LoggingService.Current.WriteTrace(0, category, TraceSeverity.Unexpected, errorMessage);
        }
        public static void LogMessage(string categoryName, string errorMessage)
        {
            SPDiagnosticsCategory category = LoggingService.Current.Areas[FerraraDiagnosticAreaName].Categories[categoryName];
            LoggingService.Current.WriteTrace(0, category, TraceSeverity.Monitorable, errorMessage);
        }
    }
}
