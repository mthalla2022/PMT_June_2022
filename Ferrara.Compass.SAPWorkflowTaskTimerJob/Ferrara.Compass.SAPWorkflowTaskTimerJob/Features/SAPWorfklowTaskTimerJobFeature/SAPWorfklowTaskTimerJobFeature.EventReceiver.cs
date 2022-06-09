using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace Ferrara.Compass.SAPWorkflowTaskTimerJob.Features.SAPWorfklowTaskTimerJobFeature
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("90e753d0-524e-44c9-b701-27d2cfe79232")]
    public class SAPWorfklowTaskTimerJobFeatureEventReceiver : SPFeatureReceiver
    {
        const string JOBNAME = "PMT SAP Workflow Task Timer";

        // Uncomment the method below to handle the event raised after a feature has been activated.
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate ()
                {
                    SPWebApplication parentWebApp = (SPWebApplication)properties.Feature.Parent;
                    DeleteExistingJob(JOBNAME, parentWebApp);
                    CreateJob(parentWebApp);
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.
        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            lock (this)
            {
                try
                {
                    SPSecurity.RunWithElevatedPrivileges(delegate ()
                    {
                        SPWebApplication parentWebApp = (SPWebApplication)properties.Feature.Parent;
                        DeleteExistingJob(JOBNAME, parentWebApp);
                    });
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}

        private bool CreateJob(SPWebApplication site)
        {
            bool jobCreated = false;
            try
            {
                SAPWorkflowTaskTimerJob job = new SAPWorkflowTaskTimerJob(JOBNAME, site);
                /*SPMinuteSchedule schedule = new SPMinuteSchedule();
                schedule.BeginSecond = 0;
                schedule.EndSecond = 59;
                schedule.Interval = 1;*/
                SPDailySchedule schedule = new SPDailySchedule();
                schedule.BeginHour = 21;
                schedule.BeginMinute = 0;
                schedule.EndHour = 23;
                schedule.EndMinute = 59;

                job.Schedule = schedule;

                job.Update();
            }
            catch (Exception)
            {
                return jobCreated;
            }
            return jobCreated;
        }
        public bool DeleteExistingJob(string jobName, SPWebApplication site)
        {
            bool jobDeleted = false;
            try
            {
                foreach (SPJobDefinition job in site.JobDefinitions)
                {
                    if (job.Name == jobName)
                    {
                        job.Delete();
                        jobDeleted = true;
                    }
                }
            }
            catch (Exception)
            {
                return jobDeleted;
            }
            return jobDeleted;
        }
    }
}
