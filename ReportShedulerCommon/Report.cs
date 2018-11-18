namespace ReportShedulerCommon
{
    using System;
    using System.Collections.Generic;

    public abstract class Report
    {
        public string Name { get; set; }
        public ReportType Type { get; }
        public IEnumerable<MonitoredObject> MonitoredObjects { get; set; }
        public DateTime FirstBuildTime { get; set; }
        public TimeSpan BuildPeriod { get; set; }
    }
}
