using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using kafer_house.Extensions;
using kafer_house.Helper;

namespace kafer_house.Controllers
{
    public class AlertableController : Controller
    { 
        public void Success(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Success, message, dismissable);
        }
        public void Information(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Information, message, dismissable);
        }
        public void Warning(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Warning, message, dismissable);
        }
        public void Danger(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Danger, message, dismissable);
        }

        private void AddAlert(string alertStyle, string message, bool dismissable)
        {
         
            var alerts = TempData.DeserializeAlerts(Alert.TempDataKey);

            alerts.Add(new Alert{
                AlertStyle = alertStyle,
                Message = message,
                Dismissable = dismissable
            });

            TempData.SerializeAlerts(Alert.TempDataKey, alerts);
        }
    }
}